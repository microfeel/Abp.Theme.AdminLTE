﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;
using Volo.Abp.TenantManagement;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.Data
{
    public class AdminLTEDemoDbMigrationService : ITransientDependency
    {
        public ILogger<AdminLTEDemoDbMigrationService> Logger { get; set; }

        private readonly IDataSeeder _dataSeeder;
        private readonly IAdminLTEDemoDbSchemaMigrator _dbSchemaMigrator;
        private readonly ITenantRepository _tenantRepository;
        private readonly ICurrentTenant _currentTenant;

        public AdminLTEDemoDbMigrationService(
            IDataSeeder dataSeeder,
            IAdminLTEDemoDbSchemaMigrator dbSchemaMigrator,
            ITenantRepository tenantRepository,
            ICurrentTenant currentTenant)
        {
            _dataSeeder = dataSeeder;
            _dbSchemaMigrator = dbSchemaMigrator;
            _tenantRepository = tenantRepository;
            _currentTenant = currentTenant;

            Logger = NullLogger<AdminLTEDemoDbMigrationService>.Instance;
        }

        public async Task MigrateAsync()
        {
            Logger.LogInformation("Started database migrations...");

            await MigrateHostDatabaseAsync();

            var i = 0;
            var tenants = await _tenantRepository.GetListAsync();
            foreach (var tenant in tenants)
            {
                i++;

                using (_currentTenant.Change(tenant.Id))
                {
                    Logger.LogInformation($"Migrating {tenant.Name} database schema... ({i} of {tenants.Count})");
                    await MigrateTenantDatabasesAsync(tenant);
                    Logger.LogInformation($"Successfully completed {tenant.Name} database migrations.");
                }
            }

            Logger.LogInformation("Successfully completed database migrations.");
        }

        private async Task MigrateHostDatabaseAsync()
        {
            Logger.LogInformation("Migrating host database schema...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation("Executing host database seed...");
            await _dataSeeder.SeedAsync();

            Logger.LogInformation("Successfully completed host database migrations.");
        }

        private async Task MigrateTenantDatabasesAsync(Tenant tenant)
        {
            Logger.LogInformation($"Migrating schema for {tenant.Name} database...");
            await _dbSchemaMigrator.MigrateAsync();

            Logger.LogInformation($"Executing {tenant.Name} tenant database seed...");
            await _dataSeeder.SeedAsync(tenant.Id);
        }
    }
}