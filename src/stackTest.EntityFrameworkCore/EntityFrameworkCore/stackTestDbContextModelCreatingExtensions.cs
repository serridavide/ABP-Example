using Microsoft.EntityFrameworkCore;
using stackTest.Entities.Childs;
using stackTest.Entities.Fathers;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace stackTest.EntityFrameworkCore
{
    public static class stackTestDbContextModelCreatingExtensions
    {
        public static void ConfigurestackTest(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Father>(b =>
            {
                b.ToTable(stackTestConsts.DbTablePrefix + "Father", stackTestConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });

            builder.Entity<Child>(b =>
            {
                b.ToTable(stackTestConsts.DbTablePrefix + "Child", stackTestConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });
        }
    }
}