using Microsoft.EntityFrameworkCore;
using TicketBookingApi.Models;
using static Azure.Core.HttpHeader;

namespace TicketBookingApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Location> Locations { get; set; }
    }
}
