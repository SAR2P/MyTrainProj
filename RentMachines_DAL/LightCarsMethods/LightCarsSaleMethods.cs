using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppEntitys.Context;//
using AppEntitys.Models;//

namespace RentMachines_DAL.LightCarsMethods
{
    public class LightCarsSaleMethods
    {

        ContextM ctx = new ContextM();
       



        public void RegisterCar(LightCarSalesReportClass l1)
        {
            ctx.LightCarSalesTable.Add(l1);
            ctx.SaveChanges();
        
        }


        public List<LightCarSalesReportClass> ReadSaleTable() 
        {
            var q = from i in ctx.LightCarSalesTable select i;
             return q.ToList();
        }

        public void EditeLiteCarSaleTable(int Id , LightCarSalesReportClass l2) 
        {
            var q = from i in ctx.LightCarSalesTable where i.LightCarSalesReportClassId == Id  select i;
          
            var h = q.Single();
            
            h.SalesDate = l2.SalesDate;
            h.price = l2.price;
            h.Description = l2.Description;
            h.customer = l2.customer;
            h.LightCar = l2.LightCar;
        
        }

    }
}
