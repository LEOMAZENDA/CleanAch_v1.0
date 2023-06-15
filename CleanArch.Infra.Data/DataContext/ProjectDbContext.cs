using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.DataContext
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


        //#region PEGANDO STRING DE CONEXÃO PELO appsettings
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(GetStringConectionConfig());
        //        base.OnConfiguring(optionsBuilder);
        //    }
        //}


        //private string GetStringConectionConfig()
        //{
        //    IConfigurationRoot configurationManager = new ConfigurationBuilder()
        //        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //    string strCon = configurationManager.GetConnectionString("DefaultConnection");

        //    return strCon;
        //}

        //#endregion


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ProjectDbContext).Assembly); 
            // Devido a esse builkd na lina de cima, o Enity pega de forma automatica as classes configuradas via fluenteApi 
        }


    }
}
