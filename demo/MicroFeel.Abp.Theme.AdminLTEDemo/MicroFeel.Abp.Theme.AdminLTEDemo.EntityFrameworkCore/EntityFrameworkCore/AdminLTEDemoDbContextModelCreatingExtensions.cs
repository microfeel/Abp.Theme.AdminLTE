using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.Users;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.EntityFrameworkCore
{
    public static class AdminLTEDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureAdminLTEDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AdminLTEDemoConsts.DbTablePrefix + "YourEntities", AdminLTEDemoConsts.DbSchema);

            //    //...
            //});
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}