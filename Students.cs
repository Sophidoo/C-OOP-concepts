using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{

    /*Abstract Class*/
    public  abstract class Students
    {

        public abstract void addStudent(string fname, string lname, int age);
        public abstract Boolean isFeePaid(Boolean False);
        public void display()
        {
            
        }

    }


    
    public class StudentImplement : Students
    {
        private string fname;
        private string lname;
        private int age;
        public override void addStudent(string fname, string lname, int age)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
        }

        public void display()
        {
            Console.WriteLine("FullName: {0} Lastname: {1}", fname, lname);
            Console.WriteLine("Age: {0}", age);
        }

        public override bool isFeePaid(bool False)
        {
            throw new NotImplementedException();
        }
    }


    /*Interface Class*/
    public interface Employee
    {
        public abstract void Employee(string fname, string lname, int age, Address adr);
        public abstract int Checkout(int level);
    }

    public class EmployeeImplement : Employee
    {
        private string fname;
        private string lname;
        private int age;
        public int level;
        private Address adr;

        public void Employee(string fname, string lname, int age, Address adr)
        {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.adr = adr;
        }

        public int Checkout(int level)
        {
            return this.level = level;
        }

        
        public void viewEmployee()
        {
            Console.WriteLine("Employee Name: {0} {1}", fname, lname);
            Console.WriteLine("Employee Age: {0}", age);
            Console.WriteLine("Address: {0} {1}", adr.getCity(), adr.getStreet());
            if(level > 5)
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("Junior");
            }
        }

    }

    



    /*Polymorphism*/
    public class Mathematics
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(double a, int b)
        {
            return Convert.ToInt32(a) + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    /*Overriding*/
    public class Bonus
    {
        public double salary;
        public double addBonus(int bonus)
        {
            return salary += bonus;
        }
    }

    public class Manager : Bonus
    {
        public  double addBonus(int bonus)
        {
            return salary = bonus + 3000;
        }
    }
     


}
