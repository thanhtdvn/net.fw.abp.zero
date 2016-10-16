﻿using SimpleZero.EntityFramework;
using EntityFramework.DynamicFilters;

namespace SimpleZero.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly SimpleZeroDbContext _context;

        public InitialHostDbBuilder(SimpleZeroDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            
        }
    }
}
