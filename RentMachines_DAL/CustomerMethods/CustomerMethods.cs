using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppEntitys.Models;//
using AppEntitys.Context;//

namespace RentMachines_DAL.CustomerMethods
{
    public class CustomerMethods
    {

        ContextM ctx = new ContextM();
       



        public void Create(CustomersInformationClass c1) 
        {
            ctx.CustomerTable.Add(c1);
            ctx.SaveChanges();
        
        }

        public List<CustomersInformationClass> ReadCustomer() 
        {
            var q = from i in ctx.CustomerTable select i;
            return q.ToList();
        
        }


    }
}
