using System.Security.Cryptography.X509Certificates;

namespace absclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Abstraction*/
            StudentImplement studentImplement = new StudentImplement();
            studentImplement.addStudent("Sophia", "Okosodo", 28);
            studentImplement.display();
            Console.WriteLine();

            /*Aggregation*/
            Address address = new Address();
            address.setCity("Island");
            address.setStreet("Lagos");
            address.displayDetails();
            Console.WriteLine();

            /*Interface*/
            EmployeeImplement employeeImplement = new EmployeeImplement();
            employeeImplement.Employee("Sophia", "Okosodo", 20, address);
            employeeImplement.viewEmployee();
            Console.WriteLine();

            /*Polymorphism overloading*/
            Mathematics maths = new Mathematics();
            Console.WriteLine(maths.Add(5, 6, 3) + "\n");

            /*Polymorphism Overriding*/
            Bonus bonus = new Bonus();
            Console.WriteLine(bonus.addBonus(56));
            Console.WriteLine();

            Manager mang = new Manager();
            Console.WriteLine(mang.addBonus(56));


            /*Enum*/
            Console.WriteLine();
            PeopleImplement people = new PeopleImplement();
            people.addPeople(13, Gender.FEMALE);
            people.ViewAddPeople();
        }
    }
}