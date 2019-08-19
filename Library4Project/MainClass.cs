using Library4Project.Model;
using System;

namespace Library4Project
{
    public class MainClass
    {
        private WorkOrderList[] workOrderList = new WorkOrderList[]
        {
                new WorkOrderList
                {
                    workOrder ="1001",
                    startTime = new DateTime(2017,01,01,08,00,00),
                    finishTime = new DateTime(2017,01,01,16,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1002",
                    startTime = new DateTime(2017,01,01,16,00,00),
                    finishTime = new DateTime(2017,01,02,00,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1003",
                    startTime = new DateTime(2017,01,02,00,00,00),
                    finishTime = new DateTime(2017,01,02,08,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1004",
                    startTime = new DateTime(2017,01,02,08,00,00),
                    finishTime = new DateTime(2017,01,02,16,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1005",
                    startTime = new DateTime(2017,01,02,16,00,00),
                    finishTime = new DateTime(2017,01,03,00,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1006",
                    startTime = new DateTime(2017,01,03,00,00,00),
                    finishTime = new DateTime(2017,01,03,08,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1007",
                    startTime = new DateTime(2017,01,03,08,00,00),
                    finishTime = new DateTime(2017,01,03,16,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1008",
                    startTime = new DateTime(2017,01,03,16,00,00),
                    finishTime = new DateTime(2017,01,04,00,00,00)
                },

                new WorkOrderList
                {
                    workOrder ="1009",
                    startTime = new DateTime(2017,01,04,00,00,00),
                    finishTime = new DateTime(2017,01,04,08,00,00)
                },

                //new WorkOrderList
                //{
                //    workOrder ="1010",
                //    startTime = new DateTime(2017,01,04,08,00,00),
                //    finishTime = new DateTime(2017,01,04,16,00,00)
                //}
        };

        private StopList[] stopList = new StopList[]
        {
            new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,01,10,00,00),
                    finishTime = new DateTime(2017,01,01,10,10,00)
                },

                new StopList
                {
                    stopReason = "Arıza",
                    startTime = new DateTime(2017,01,01,10,30,00),
                    finishTime = new DateTime(2017,01,01,11,00,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,01,12,00,00),
                    finishTime = new DateTime(2017,01,01,12,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,01,14,00,00),
                    finishTime = new DateTime(2017,01,01,14,10,00)
                },

                new StopList
                {
                    stopReason = "Setup",
                    startTime = new DateTime(2017,01,01,15,00,00),
                    finishTime = new DateTime(2017,01,01,16,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,01,18,00,00),
                    finishTime = new DateTime(2017,01,01,18,10,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,01,20,00,00),
                    finishTime = new DateTime(2017,01,01,20,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,01,22,00,00),
                    finishTime = new DateTime(2017,01,01,22,10,00)
                },

                new StopList
                {
                    stopReason = "Arge",
                    startTime = new DateTime(2017,01,01,23,00,00),
                    finishTime = new DateTime(2017,01,02,08,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,02,10,00,00),
                    finishTime = new DateTime(2017,01,02,10,10,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,02,12,00,00),
                    finishTime = new DateTime(2017,01,02,12,30,00)
                },

                new StopList
                {
                    stopReason = "Arıza",
                    startTime = new DateTime(2017,01,02,13,00,00),
                    finishTime = new DateTime(2017,01,02,13,45,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,02,14,00,00),
                    finishTime = new DateTime(2017,01,02,14,10,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,02,18,00,00),
                    finishTime = new DateTime(2017,01,02,18,10,00)
                },

                new StopList
                {
                    stopReason = "Arge",
                    startTime = new DateTime(2017,01,02,20,00,00),
                    finishTime = new DateTime(2017,01,03,02,10,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,03,04,00,00),
                    finishTime = new DateTime(2017,01,03,04,30,00)
                },

                new StopList
                {
                    stopReason = "Setup",
                    startTime = new DateTime(2017,01,03,06,00,00),
                    finishTime = new DateTime(2017,01,03,09,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,03,10,00,00),
                    finishTime = new DateTime(2017,01,03,10,10,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,03,12,00,00),
                    finishTime = new DateTime(2017,01,03,12,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,03,14,00,00),
                    finishTime = new DateTime(2017,01,03,14,10,00)
                },

                new StopList
                {
                    stopReason = "Arıza",
                    startTime = new DateTime(2017,01,03,15,00,00),
                    finishTime = new DateTime(2017,01,03,18,45,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,03,20,00,00),
                    finishTime = new DateTime(2017,01,03,20,30,00)
                },

                new StopList
                {
                    stopReason = "Mola",
                    startTime = new DateTime(2017,01,03,22,00,00),
                    finishTime = new DateTime(2017,01,03,22,10,00)
                },

                //new StopList
                //{
                //    stopReason = "Tatil",
                //    startTime = new DateTime(2017,01,04,00,00,00),
                //    finishTime = new DateTime(2017,01,08,00,00,00)
                //},4
        };

        public WorkOrderList[] GetWorkOrderList()
        {
            return workOrderList;
        }

        public StopList[] GetStopList()
        {
            return stopList;
        }
    }
}
