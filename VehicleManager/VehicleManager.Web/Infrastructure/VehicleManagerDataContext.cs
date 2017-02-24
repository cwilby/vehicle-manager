using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VehicleManager.Web.Models;

namespace VehicleManager.Web.Infrastructure
{
    public class VehicleManagerDataContext : DbContext
    {
        public VehicleManagerDataContext()
        {

        }

        public IDbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}