using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iPortfolio.ASP.Net.WebApp.Models
{
    public class viewmodel
    {
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}