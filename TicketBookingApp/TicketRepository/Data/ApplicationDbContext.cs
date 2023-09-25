using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketRepository.Entity.City;
using TicketRepository.Entity.Court;
using TicketRepository.Entity.Ground;
using TicketRepository.Entity.Section;

namespace TicketRepository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
             
        }
        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<GroundEntity> Grounds { get; set; }
        public DbSet<CourtEntity> Courts { get; set; }
        public DbSet<SectionEntity> Sections { get; set; }
    }
}
