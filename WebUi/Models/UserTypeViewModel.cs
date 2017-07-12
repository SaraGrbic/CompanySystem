using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUi.Models
{
    public class UserTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => Name + " " + LastName;
        public string UserTypeName{ get; set; }
        public string Action { get; set; }
    }
}