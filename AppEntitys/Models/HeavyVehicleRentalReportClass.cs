using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntitys.Models
{
    public class HeavyVehicleRentalReportClass
    {

        public int HeavyVehicleRentalReportClassId { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime ReciveTheCarDate { get; set; }

        public double RentPrice { get; set; }

        //------------------------------------------------------
        public HeavyVehiclesClass heavyVehicles { get; set; }

        public CustomersInformationClass customers { get; set; }


    }
}
