using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntitys.Models
{
    public class LightCarSalesReportClass
    {

        public int LightCarSalesReportClassId { get; set; }

        public DateTime SalesDate { get; set; }

        public double price { get; set; }

        public string Description { get; set; }

        //------------------------------------------------------





        public CustomersInformationClass customer { get; set; }


        public LightCarsClass LightCar { get; set; }




    }
}
