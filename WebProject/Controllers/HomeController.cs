using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
using Library4Project.Model;
using Library4Project;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MyModel myModel = new MyModel();
            myModel.workOrdersList = new MainClass().GetWorkOrderList();
            myModel.stopList = new MainClass().GetStopList();

            List<string> lst = getReasons(myModel.stopList);

            int[,] arr = new int[myModel.workOrdersList.Length, lst.Count];

            string[,] newArr = new string[myModel.workOrdersList.Length + 2, lst.Count + 2];

            createArray(myModel.workOrdersList, myModel.stopList, lst, arr);

            fillNewArray(myModel.workOrdersList, lst, arr, newArr);

            var q = new ModelDTO
            {
                array = newArr
            };

            return View(q);
        }

        public IActionResult ExportExcel()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void fillNewArray(WorkOrderList[] workOrderList, List<string> lst, int[,] arr, string[,] newArr)
        {
            newArr[0, 0] = "İş Emri";
            for (int i = 1; i < newArr.GetLength(1) - 1; i++)
            {
                newArr[0, i] = lst[i - 1];
            }
            newArr[0, newArr.GetLength(1) - 1] = "Toplam";

            for (int i = 1; i < newArr.GetLength(0) - 1; i++)
            {
                newArr[i, 0] = workOrderList[i - 1].workOrder;
                int[] tempRow = arr.row(i - 1);
                for (int j = 1; j < tempRow.Length + 1; j++)
                {
                    newArr[i, j] = tempRow[j - 1].ToString();
                }
                newArr[i, newArr.GetLength(1) - 1] = arrayTotal(tempRow).ToString();
            }

            newArr[newArr.GetLength(0) - 1, 0] = "Toplam";

            int total = 0;
            for (int i = 1; i < newArr.GetLength(1) - 1; i++)
            {
                int[] tempCol = arr.column(i - 1);
                int tempTotal = arrayTotal(tempCol);
                total += tempTotal;
                newArr[newArr.GetLength(0) - 1, i] = tempTotal.ToString();
            }

            newArr[newArr.GetLength(0) - 1, newArr.GetLength(1) - 1] = total.ToString();
        }

        private static void createArray(WorkOrderList[] workOrderList, StopList[] stopList, List<string> lst, int[,] arr)
        {
            for (int i = 0; i < workOrderList.Length; i++)
            {
                DateTime t1 = workOrderList[i].startTime;
                DateTime t2 = workOrderList[i].finishTime;

                for (int j = 0; j < stopList.Length; j++)
                {
                    DateTime t3 = stopList[j].startTime;
                    DateTime t4 = stopList[j].finishTime;

                    if (t1 <= t4 && t3 <= t2)
                    {
                        if (t1 <= t3 && t4 <= t2)
                        {
                            TimeSpan span = t4 - t3;
                            int k = lst.IndexOf(stopList[j].stopReason);
                            arr[i, k] += (int)span.TotalMinutes;
                        }
                        else if (t3 <= t1 && t4 <= t2)
                        {
                            TimeSpan span = t4 - t1;
                            int k = lst.IndexOf(stopList[j].stopReason);
                            arr[i, k] = (int)span.TotalMinutes;
                        }
                        else if (t1 <= t3 && t2 <= t4)
                        {
                            TimeSpan span = t2 - t3;
                            int k = lst.IndexOf(stopList[j].stopReason);
                            arr[i, k] = (int)span.TotalMinutes;
                        }
                        else if (t3 <= t1 && t2 <= t4)
                        {
                            TimeSpan span = t2 - t1;
                            int k = lst.IndexOf(stopList[j].stopReason);
                            arr[i, k] = (int)span.TotalMinutes;
                        }
                    }
                }
            }
        }

        private List<string> getReasons(StopList[] stopList)
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < stopList.Length; i++)
            {
                if (lst.IndexOf(stopList[i].stopReason) == -1)
                {
                    lst.Add(stopList[i].stopReason);
                }
            }
            return lst;
        }

        private int arrayTotal(int[] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }

    }
}
