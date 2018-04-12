using BenProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenProject.Infrastructure.Data.Repository
{
    public class FamilyRepository: DataProvider
    {
        private static FamilyRepository _instance = null;
        public static FamilyRepository Instance
        {
            get
            {
                return _instance ?? new FamilyRepository();
            }
        }

        public List<Family> GetFamilies()
        {
            try
            {
                var datacontext = GetDataContext();
                return datacontext.Families.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
