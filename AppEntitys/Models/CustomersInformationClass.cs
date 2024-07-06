using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntitys.Models
{
    public class CustomersInformationClass
    {
        public int CustomersInformationClassId { get; set; }

        public string FullName { get; set; }

        public string Job { get; set; }

        public double PhoneNumber { get; set; }

        //------------------------------------------------------






        public List<HeavyVehicleRentalReportClass> heavyVehicleRentals { get; set; }
        public List<HeavyVehicleSalesReportClass> heavyVehicleSales { get; set; }
        public List<LightCarRentalReportClass> lightCarRentalReports { get; set; }
        public List<LightCarSalesReportClass> lightCarSales { get; set; }
        


    }
}
