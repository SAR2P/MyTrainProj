using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEntitys.Models
{
    public class LightCarsClass
    {
        public int LightCarsClassId { get; set; }

        public string CarName { get; set; }

        public string CarBrand { get; set; }

        public DateTime CarsDateModel { get; set; }

        public double CarsBuyPriceForUs { get; set; }

        public double CarsSellPrice { get; set; }

        public double CarsRentPrice { get; set; }

        public byte CarsCondition { get; set; }//در صورت برابر رودن با یک ماشین در دسترس است
                                               //در صورت برابر بودن با دو ماشین اجاره داده شده است
                                               //در صورت برابر بودن با سه خودرو به فروش رفته است


        //------------------------------------------------------
        public List<LightCarRentalReportClass> RentReportEntity { get; set; }

        public List<LightCarSalesReportClass> SaleReportEntity { get; set; }



    }
}
