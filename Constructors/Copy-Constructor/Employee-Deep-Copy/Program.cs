using System;

namespace CopyConstructorObject
{
   
    public class Department
    {
        public string DeptName;

        
        public Department(string deptName)
        {
            this.DeptName = deptName;
        }

       
        public Department(Department existDept)
        {
            this.DeptName = existDept.DeptName;   
        }


        public void Display()
        {
            Console.WriteLine($"Department: {DeptName}");
        }
    }

    
    public class Employee
    {
        public string EmpName;
        public Department Dept; 

       
        public Employee(string empName, Department dept)
        {
            this.EmpName = empName;
            this.Dept = dept;

          
        }

    
        public Employee(Employee existEmp)
        {
            this.Dept = new Department(existEmp.Dept);
            this.EmpName = existEmp.EmpName;
        }


        public void Display()
        {
            Console.WriteLine($"Employee Name: {EmpName} | Department: {Dept.DeptName}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
         
            Department deptIT = new Department("IT");
            Employee emp1 = new Employee("Akash", deptIT);

            
            Employee emp2 = new Employee(emp1);

            Console.WriteLine("\n--- Employee Custom Object Deep Copy Demo ---\n");
            Console.WriteLine("\n[ Before Modifying emp2 ]");
            emp1.Display();
            emp2.Display();



            Console.WriteLine("\n========================================");
            Console.WriteLine("\n[ After Changing emp2 Department to \"CyberSecurity\" ]");
            emp1.Display();
            emp2.Display();
        }
    }
}
