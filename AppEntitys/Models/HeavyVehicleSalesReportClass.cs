using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntitys.Models
{
    public class HeavyVehicleSalesReportClass
    {
        public int HeavyVehicleSalesReportClassId { get; set; }

        public DateTime SalesDate { get; set; }

        public double price { get; set; }

        public string Description { get; set; }


        //------------------------------------------------------

        public CustomersInformationClass customer { get; set; }

        public HeavyVehiclesClass vehicleClass { get; set; }


    }
}
