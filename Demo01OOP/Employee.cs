using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct Employee
    {
        public int id;
        public string name;
        public double salary;

        //Applying Encapsulation Using Setter Getter Methods

        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //public int GetId()
        //{
        //    return id;
        //}

        //public void SetName(string name)
        //{
        //    if (name.Length >= 8 && name.Length <= 20)
        //        this.name = name;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetSalary(double salary)
        //{
        //    if (salary > 0)
        //        this.salary = salary;
        //}

        //public double GetSalary()
        //{
        //    return salary;
        //}

        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $"Id: {id} , Name : {name} , Salary : {salary}";
        //}

        public int Id
        {

            set
            {
               id = value;
            }

            get
            {
                return id;
            }
        }

        public string Name
        {

            set
            {
                if (value.Length >= 8 && value.Length <= 20)
                    name = value;
            }

            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                if(value > 0)
                salary = value;
            }
            get
            {
                return salary;
            }
        }

        public string Address { get; set; } 

    }
}
