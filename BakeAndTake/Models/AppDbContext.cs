using Microsoft.EntityFrameworkCore;

namespace BakeAndTake.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Pie> Pies { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed Categories
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Fruit pies", Description = "All-fruit pie" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Cheese cakes", Description = "Cheesy all the way" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Seasonal pies", Description = "Get in the mood for a seasonal pie" });

            // seed Pies
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 1,
                    Name = "Apple Pie",
                    Price = 15.95M,
                    ShortDescription = "Our famous apple pies!",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 1,
                    ImageUrl = "/images/apple-pie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/apple-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 2,
                    Name = "Blueberry Cheesecake",
                    Price = 15.95M,
                    ShortDescription = "You'll love it!",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 2,
                    ImageUrl = "/images/blueberry-cheesecake.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/blueberry-cheesecake-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 3,
                    Name = "Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "Plain cheese cake. Plain pleasure.",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 2,
                    ImageUrl = "/images/cheesecake.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/cheesecake-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 4,
                    Name = "Cherry Pie",
                    Price = 15.95M,
                    ShortDescription = "A summer classic!",
                    LongDescription =
                        "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 1,
                    ImageUrl = "/images/cherry-pie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/cherry-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 5,
                    Name = "Christmas Apple Pie",
                    Price = 13.95M,
                    ShortDescription = "Happy holidays with this pie!",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 3,
                    ImageUrl = "/images/christmas-apple-pie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/christmas-apple-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 6,
                    Name = "Cranberry Pie",
                    Price = 17.95M,
                    ShortDescription = "A Christmas favorite",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 3,
                    ImageUrl = "/images/cranberry-pie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/cranberry-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 7,
                    Name = "Peach Pie",
                    Price = 15.95M,
                    ShortDescription = "Sweet as peach",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 1,
                    ImageUrl = "/images/peach-pie.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/peach-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 8,
                    Name = "Pumpkin Pie",
                    Price = 12.95M,
                    ShortDescription = "Our Halloween favorite",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 3,
                    ImageUrl = "/images/pumpkin-pie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = true,
                    ImageThumbnail = "/images/pumpkin-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 9,
                    Name = "Strawberry Pie",
                    Price = 15.95M,
                    ShortDescription = "Our delicious strawberry pie!",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 1,
                    ImageUrl = "/images/strawberry-pie.jpg",
                    InStock = true,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/strawberry-pie-small.jpg",
                    AllergyInformation = ""
                }
            );
            modelBuilder.Entity<Pie>().HasData(
                new Pie
                {
                    Id = 10,
                    Name = "Strawberry Cheese Cake",
                    Price = 18.95M,
                    ShortDescription = "You'll love it!",
                    LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                    CategoryId = 2,
                    ImageUrl = "/images/strawberry-cheesecake.jpg",
                    InStock = false,
                    IsPieOfTheWeek = false,
                    ImageThumbnail = "/images/strawberry-cheesecake-small.jpg",
                    AllergyInformation = ""
                }
            );

        }
    }
}
