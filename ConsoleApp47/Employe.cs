using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employer
{
    class Employe
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public double Salary { get; set; }

        public Employe(string Sor)
        {
            string[] adat = Sor.Split(';');
            Name = adat[0];
            Age = int.Parse(adat[1]);
            City = adat[2];
            Department = adat[3];
            Position = adat[4];
            Gender = adat[5];
            MaritalStatus = adat[6];
            Salary = double.Parse(adat[7]);
        }

        public double Fizetes()
        {
            return Salary * 12 * 390;

        }
    }
}

