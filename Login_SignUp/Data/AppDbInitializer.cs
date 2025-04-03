using Login_SignUp.Data.Static;
using Login_SignUp.Models;
using Microsoft.AspNetCore.Identity;

namespace Login_SignUp.Data
{
    public class AppDbInitializer {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
<<<<<<< Updated upstream
                            name = "Ace",
                            Logo="\\Login_SignUp\\wwwroot\\img\\undraw_posting_photo.svg",
=======
                            Item = "Ace",
                            Logo="/assets/images/Hp1.jpg",
>>>>>>> Stashed changes
                            Category ="Maize meal",
                            Specification = "10 kg",
                            Price= 99,
                        },
                        new Product()
                        {
                            name = "Bull Brand",
                            Logo="https://th.bing.com/th/id/R.73d5420e270793db01373ab6f85b2771?rik=w0MDH9zB5GmThQ&pid=ImgRaw&r=0",
                            Category ="Canned Food",
                            Specification = "300g",
                            Price= 38,
                        },
                        new Product()
                        {
                            name = "Vegitable Oil",
                            Logo="https://th.bing.com/th/id/OIP.17fSe1aWIPa4YawxoQifZAHaHa?pid=ImgDet&rs=1",
                            Category ="Oil",
                            Specification = "2lt",
                            Price= 87,
                        },
                        new Product()
                        {
                            name = "Coca Cola",
                            Logo="https://th.bing.com/th/id/OIP.TFloL5PqMIdBMYREKQOEegHaHa?w=218&h=218&c=7&r=0&o=5&pid=1.7",
                            Category ="Soda",
                            Specification = "2lt",
                            Price= 19,
                        },
                        new Product()
                        {
                            name = "Bananas",
                            Logo="https://th.bing.com/th/id/OIP.iHUuWz6FROXxbz7JB2JkYQHaHa?w=173&h=180&c=7&r=0&o=5&pid=1.7",
                            Category ="Fruits",
                            Specification = "1kg",
                            Price= 22,
                        },
                        new Product()
                        {
                            name = "Impala",
                            Logo="https://th.bing.com/th/id/OIP.HglzxUyxGM0-spLTz7JBQwAAAA?w=205&h=205&c=7&r=0&o=5&pid=1.7",
                            Category ="Maize meal",
                            Specification = "10 kg",
                            Price= 68,
                        },
                        new Product()
                        {
                            name = "Lucky Star",
                            Logo="https://th.bing.com/th/id/OIP.uYqSMqwi7MyInsOMruSD6AHaGy?w=207&h=190&c=7&r=0&o=5&pid=1.7",
                            Category ="Canned Food",
                            Specification = "750g",
                            Price= 17,
                        }

                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder) {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@cty.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null) {
                    var newAdminUser = new ApplicationUser() {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@cty.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null) {
                    var newAppUser = new ApplicationUser() {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
         
    }
}
