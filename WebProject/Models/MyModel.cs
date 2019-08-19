using Library4Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class ModelDTO
    {
        public string[,] array { get; set; }
    }
    public class MyModel
    {
        public WorkOrderList[] workOrdersList { get; set; }
        public StopList[] stopList { get; set; }
    }
}
