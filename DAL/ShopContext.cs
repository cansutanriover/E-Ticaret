namespace DAL
{
    using DAL.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ShopContext : DbContext
    {
        // Your context has been configured to use a 'ShopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.ShopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ShopContext' 
        // connection string in the application configuration file.
        public ShopContext()
            : base("name=ShopDB")//veritabanýnda oluþacak veritaný adý
        {
            Database.SetInitializer(new Configuration());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShopHistory> ShopHistories { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    public class Configuration:CreateDatabaseIfNotExists<ShopContext>/*Database yoksa oluþtur ve aþaðýda verilen verileri ekle*/
    {
        protected override void Seed(ShopContext context)
        {
            context.Users.Add(new User() {Name="Bill",Surname="Gates" });
            context.Users.Add(new User() {Name="Nil", Surname="Gates" });

            context.Products.AddRange(new Product[]
            {
                new Product(){Name="telefon",Image="aðaç.jpg",Price=1500 },
                new Product(){Name="bilgisayar",Image="göl.jpg",Price=10000 },
                new Product(){Name="tv",Image="ray.jpg", Price=3000}
            });

            context.SaveChanges();
        }
    }
}