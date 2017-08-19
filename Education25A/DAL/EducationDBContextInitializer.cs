using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Education25A.DAL
{
    public class EducationDBContextInitializer: 
        System.Data.Entity.DropCreateDatabaseIfModelChanges<EducationDBContext>
    
    {
        protected override void Seed(EducationDBContext context)
        {
            base.Seed(context);
        }
    }
}