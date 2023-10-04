using Microsoft.EntityFrameworkCore;
using VerticalSliceArchitecture.Features.Offices.Models;

namespace VerticalSliceArchitecture.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<OfficeEntity> offices { get; set; }
    }
}
