using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;//
using AppEntitys.Models;


namespace AppEntitys.Context
{
    public class ContextM:DbContext//
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source =.; initial catalog=RentingMachines; Integrated security = true; TrustServerCertificate=True");
        }

        public DbSet<CustomersInformationClass> CustomerTable { get; set; }
        public DbSet<HeavyVehiclesClass> HeavyVehiclesTable { get; set; }
        public DbSet<HeavyVehicleSalesReportClass> heavyVehicleSalesTable { get; set; }
        public DbSet<HeavyVehicleRentalReportClass> heavyVehicleRentalReportTable { get; set; }
        public DbSet<LightCarsClass> lightCarsTable { get; set; }
        public DbSet<LightCarSalesReportClass> LightCarSalesTable { get; set; }
        public DbSet<LightCarRentalReportClass> lightCarRentalsTable { get; set; }
        

    }
}
