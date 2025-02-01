using Microsoft.EntityFrameworkCore;
using dotnetAPI.Data;
using dotnetAPI.Models;

namespace dotnetAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<CareRoom> Rooms { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options )
            :base(options)
        {

        }
    }
}
