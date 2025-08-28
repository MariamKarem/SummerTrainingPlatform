using Microsoft.EntityFrameworkCore;
using SummerTrainingPlatform.DataAccessLayer.Models.Training_ProvidersModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerTrainingPlatform.DataAccessLayer.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Training_Provider> Training_Providers { get; set; }
    }
}
