using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CMSMvc.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
	public DbSet<CMSMvc.Models.Article> Articles { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<CMSMvc.Models.Article>()
			.HasOne(a => a.Author)
			.WithMany()
			.HasForeignKey(a => a.AuthorId)
			.IsRequired(false)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
