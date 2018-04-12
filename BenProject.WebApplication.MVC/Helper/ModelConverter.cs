using BenProject.Core.Model;
using BenProject.WebApplication.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenProject.WebApplication.MVC.Helper
{
    public class ModelConverter
    {
        public static List<FamilyViewModel> ToFamilyViewModel(List<Family> families)
        {
            try
            {
                List<FamilyViewModel> familyViewModels = new List<FamilyViewModel>();
                foreach (var family in families)
                {
                    familyViewModels.Add(new FamilyViewModel()
                    {
                        FamilyID = family.FamilyID,
                        Name = family.Name,
                        MemberCount = family.Individuals.Count
                    });
                }
                return familyViewModels;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}