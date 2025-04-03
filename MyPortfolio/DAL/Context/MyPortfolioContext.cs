using Microsoft.EntityFrameworkCore;
using MyPortolio.DAL.Entities;
namespace MyPortolio.DAL.Context
{
  public class MyPortfolioContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=DESKTOP-B4HNKH7;initial Catalog=MyPortfolioDb;integrated Security=true;");
    }

    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Features> Features { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Portfoloio> Portfolios { get; set;}
    public DbSet<Skill> Skills { get; set;}
    public DbSet<SocialMedia> SocialMedias { get; set;}
    public DbSet<Testimonial> Testimonials { get; set; }

  }
}
