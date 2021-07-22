using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Teacher : Occupation
    {
        private string Name = "";
        public  Double Salary;

        public Teacher(string name, Double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Whoami()
        {
            return this.Name + " is a Teacher";
        }
        public double GetTex()
        {
            return this.Salary - (this.Salary * 0.09);
        }


    }
}
