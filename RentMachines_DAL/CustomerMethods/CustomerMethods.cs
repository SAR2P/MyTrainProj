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

        ContextM ctx1 = new ContextM();
       



        public void Create(CustomersInformationClass c1) 
        {
            ctx1.CustomerTable.Add(c1);
            ctx1.SaveChanges();
        
        }

        public List<CustomersInformationClass> ReadCustomer() 
        {
            var q = (from i in ctx1.CustomerTable select i).ToList();
            return q.ToList();
        
        }


    }
}
