//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;
//namespace Rev
//{
//    public class Report
//    {
//        public delegate bool testdelegate(Employee e);
//        public void Employeeprocess(Employee[] e, string Title, testdelegate testdelegate)
//        {
//            WriteLine(Title);
//            WriteLine("~-----------------------------------------------------------------~");
//            foreach (Employee emp in e)
//            {
//                if (testdelegate(emp))
//                {
//                    WriteLine($"ID: {emp.Id} , Name: {emp.Name} , Address: {emp.Address} , City: {emp.City} ,Salary: {emp.salary}");
//                }
//            }
//            WriteLine("\n\n");
//        }
//    }
//}
