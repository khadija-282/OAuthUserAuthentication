using LoginAuthnetication.Model;
using Microsoft.EntityFrameworkCore;
using System;


namespace DAL
{
    public partial class AuthenticateUserContext: DbContext
    {
        public AuthenticateUserContext(DbContextOptions<AuthenticateUserContext> options):base (options)
        {

        }
        public DbSet<User> User { get; set; }
    }
}
