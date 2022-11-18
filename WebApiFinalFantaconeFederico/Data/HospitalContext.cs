using Microsoft.EntityFrameworkCore;
using WebApiFinalFantaconeFederico.Models;

namespace WebApiFinalFantaconeFederico.Data
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }


        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Hospital> hospitales { get; set; } 
    }
}
