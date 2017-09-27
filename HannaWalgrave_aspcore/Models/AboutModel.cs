using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HannaWalgrave_aspcore.Models
{
    public class AboutModel
    {
        public string Name { get; set; }
        public double DaysUntillBirthday { get; set; }
        public DateTime Now => DateTime.Now;
    }
}
