using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterProject
{
    public class Scooter
    {
        private string name { get; set; } = "";

        public Scooter(string name)
        {
            this.name = name;
        }

        public string GetScooterName()
        {
            return name;
        }
    }
}
