using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class SampleData
    {
        public static void Initialize(MedGenContext context)
        {
            if (!context.Patients.Any())
            {
                context.Patients.AddRange(
                    new Patient()
            );
                context.SaveChanges();
            }
        }
    }
}
