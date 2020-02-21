using System.Threading.Tasks;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Data
{
    public interface IAdminLTEDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
