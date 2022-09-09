using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalPetRegist.Models
{
    public class HospitalAPIContext:DbContext
    {
        public HospitalAPIContext(DbContextOptions<HospitalAPIContext> options) : base(options)
        {
        
        
        }

        public DbSet<HospitalAPI> HospitalAPIs { get; set; }

    }
}
