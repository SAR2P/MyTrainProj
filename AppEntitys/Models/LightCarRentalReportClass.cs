using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntitys.Models
{
    public class LightCarRentalReportClass
    {
        public int LightCarRentalReportClassId { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime ReciveTheCarDate { get; set; }

        public double RentPrice { get; set; }


        //------------------------------------------------------



        public CustomersInformationClass customer { get; set; }

        public LightCarsClass lightCar { get; set; }






    }
}
