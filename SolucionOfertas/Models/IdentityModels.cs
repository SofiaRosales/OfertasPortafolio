using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SolucionOfertas.Models
{
    // Puede agregar datos del perfil del usuario agregando más propiedades a la clase ApplicationUser. Para más información, visite http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("DBOFERTAS".ToUpper());

            modelBuilder.Entity<ApplicationUser>().ToTable("PERSONA").Property(p => p.Id).HasColumnName("ID");
            modelBuilder.Entity<ApplicationUser>().ToTable("PERSONA").Property(p => p.Email).HasColumnName("EMAIL");
            modelBuilder.Entity<ApplicationUser>().ToTable("PERSONA").Property(p => p.EmailConfirmed).HasColumnName("EMAIL_CONFIRMADO");
            modelBuilder.Entity<ApplicationUser>().ToTable("PERSONA").Property(p => p.PasswordHash).HasColumnName("PASSWORD");
            modelBuilder.Entity<ApplicationUser>().ToTable("PERSONA").Property(p => p.SecurityStamp).HasColumnName("SELLO_SEGURIDAD");
            modelBuilder.Entity<ApplicationUser>().ToTable("PERSONA").Property(p => p.UserName).HasColumnName("RUT");

            modelBuilder.Entity<IdentityUserRole>().ToTable("PERFIL_PERSONA").Property(P => P.RoleId).HasColumnName("ID_PERFIL");
            modelBuilder.Entity<IdentityUserRole>().ToTable("PERFIL_PERSONA").Property(P => P.UserId).HasColumnName("ID_PERSONA");

            modelBuilder.Entity<IdentityRole>().ToTable("PERFIL").Property(P => P.Name).HasColumnName("NOMBRE");
            modelBuilder.Entity<IdentityRole>().ToTable("PERFIL").Property(P => P.Id).HasColumnName("ID");

        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}