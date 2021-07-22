using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    public class Doctor : Occupation
    {
        public string Name = "";
        public Double Salary ;
        

        public Doctor(string name, Double salary) 
        {
            this.Name = name;
            this.Salary = salary;
        }


        public string Whoami()
        {
            return this.Name+ " is a Doctor";
        }
        public double GetTax()
        {
            return this.Salary - (this.Salary * 0.25);
        }

    }
}
