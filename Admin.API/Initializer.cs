using Admin.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Api
{
    public static class Initializer
    {
        public static void Initialize(TargetingGroupContext context)
        {
            if (!context.Interests.Any())
            {
                context.Interests.AddRange(
                    new DAL.Models.Interest
                    {
                        Name = "Test",
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}
