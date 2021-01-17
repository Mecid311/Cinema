using CinemaPro.Domain.Entity;
using CinemaPro.Domain.Entity.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaPro.Domain.DataContext
{
    public class CinemaDbContext
        : IdentityDbContext<CpUser,CpRole,int,CpUserClaim,CpUserRole,CpUserLogin,CpRoleClaim,CpUserToken>
    {
        public CinemaDbContext(DbContextOptions options)
            : base(options)
        {

        }




        public DbSet<Moviedetail> Moviedetails { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Mcast> Mcasts { get; set; }
        public DbSet<BtheS> BtheSes { get; set; }
        public DbSet<Format> Formats { get; set; }
        public DbSet<Mformat> Mformats { get; set; }
        public DbSet<Seat> Seats { get; set; }

        public DbSet<Extra> Extras { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Mcat> Mcats { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contactus> Contactuses { get; set; }
        public DbSet<Bankclient> Bankclients { get; set; }
        public DbSet<Bankcustom> Bankcustoms { get; set; }



        public DbSet<Socialmedia> Socialmedias { get; set; }
        public DbSet<Partner> Partners { get; set; }

        #region Membership
        public DbSet<CpUser> Users { get; set; }
        public DbSet<CpRole> Roles { get; set; }
        public DbSet<CpUserClaim> UserClaims { get; set; }
        public DbSet<CpRoleClaim> RoleClaims { get; set; }
        public DbSet<CpUserToken> UserTokens { get; set; }
        public DbSet<CpUserLogin> UserLogins { get; set; }
        public DbSet<CpUserRole> UserRoles { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<CpUser>(e =>
            {
                e.ToTable("Users", "Membership");
            });

            modelBuilder.Entity<CpRole>(e =>
            {
                e.ToTable("Roles", "Membership");
            });

            modelBuilder.Entity<CpRoleClaim>(e =>
            {
                e.ToTable("RoleClaims", "Membership");
            });

            modelBuilder.Entity<CpUserClaim>(e =>
            {
                e.ToTable("UserClaims", "Membership");
            });

            modelBuilder.Entity<CpUserToken>(e =>
            {
                e.ToTable("UserTokens", "Membership");
            });

            modelBuilder.Entity<CpUserLogin>(e =>
            {
                e.ToTable("UserLogins", "Membership");
            });

            modelBuilder.Entity<CpUserRole>(e =>
            {
                e.ToTable("UserRoles", "Membership");
            });
        }
    }
}
