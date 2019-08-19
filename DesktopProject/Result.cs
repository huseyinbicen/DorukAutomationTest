using Library4Project.Model;
using Library4Project;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DesktopProject
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            dataGridView_Report.Rows.Clear();
            WorkOrderList[] workOrderList = new MainClass().GetWorkOrderList();
            StopList[] stopList = new MainClass().GetStopList();

            List<string> lst = getReasons(stopList);

            int[,] arr = new int[workOrderList.Length, lst.Count];

            string[,] newArr = new string[workOrderList.Length + 2, lst.Count + 2];

            createArray(workOrderList, stopList, lst, arr);

            fillNewArray(workOrderList, lst, arr, newArr);

            fillDataGridView(newArr);
        }

        private void fillDataGridView(string[,] newArr)
        {
            int height = newArr.GetLength(0);
            int width = newArr.GetLength(1);

            this.dataGridView_Report.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView_Report);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = newArr[r, c];
                }

                this.dataGridView_Report.Rows.Add(row);
            }
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

        private void Btn_ExportExcel_Click(object sender, EventArgs e)
        {
            dataGridView_Report.SelectAll();
            DataObject dataObj = dataGridView_Report.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
            // Paste in Excel 
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true; xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select(); xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
