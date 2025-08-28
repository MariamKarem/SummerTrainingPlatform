using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerTrainingPlatform.DataAccessLayer.Models.Training_ProvidersModels
{
    public class Training_Provider
    { public int Id { get; set; }
      public string Name { get; set; }
      public string Field { get; set; }
      public string? Location { get; set; }
      public string Duration { get; set; }  
        public string? Required_Skills { get; set; }

    }
}
