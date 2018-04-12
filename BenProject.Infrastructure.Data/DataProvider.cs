using BenProject.Infrastructure.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenProject.Infrastructure.Data
{
    public class DataProvider: BenedictProjectEntities
    {
        public BenedictProjectEntities GetDataContext()
        {
            return new BenedictProjectEntities();
        }
    }
}
