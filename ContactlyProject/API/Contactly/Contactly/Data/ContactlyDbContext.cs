using Contactly._Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Contactly.Data
{
    public class ContactlyDbContext :DbContext
    {
        public ContactlyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
