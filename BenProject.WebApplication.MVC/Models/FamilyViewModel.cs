using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenProject.WebApplication.MVC.Models
{
    public class FamilyViewModel
    {
        public int FamilyID { get; set; }
        public string Name { get; set; }
        public int MemberCount { get; set; }
    }
}