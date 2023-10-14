using BookShoppingCartMVC.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection; // Đảm bảo thêm using này.

namespace BookShoppingCartMVC.Data
{
    public class DbSeeder
    {
        public static async Task SeedDefaultData(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var userMgr = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                var roleMgr = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                // Thêm các vai trò vào cơ sở dữ liệu
                await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
                await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

                var admin = new IdentityUser
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    EmailConfirmed = true
                };

                var isUserExist = await userMgr.FindByEmailAsync(admin.Email);
                if (isUserExist == null)
                {
                    await userMgr.CreateAsync(admin, "Admin@123");
                    await userMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
                }
            }
        }
    }
}
