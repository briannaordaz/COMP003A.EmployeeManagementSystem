namespace COMP003A.EmployeeManagementSystem;

class Program
{
    /// <summary>
    /// Main Method
    /// </summary>
    /// <param name="args"></param>
    /// <exception cref="ArgumentException"></exception>
    static void Main(string[] args)
    {
        
        HRDepartment hrDepartment = new HRDepartment();
        
        ITDepartment itDepartment = new ITDepartment();
        
        
        Console.WriteLine("What is your ID: ");
        string  employeeId = Console.ReadLine();
        
        Console.WriteLine("First name: ");
        string firstName = Console.ReadLine();

        if (firstName.Any(char.IsDigit))
        {
            throw new ArgumentException("First name cannot contain digits");
        }
        
        Console.WriteLine("Last name: ");
        string lastName = Console.ReadLine();

        if (lastName.Any(char.IsDigit))
        {
            throw new ArgumentException("Last name cannot contain digits");
        }
        
        Console.WriteLine("Middle name: ");
        string middleName = Console.ReadLine();

        if (middleName.Any(char.IsDigit))
        {
            throw new ArgumentException("Middle name cannot contain digits");
        }
        
        Console.WriteLine("Salary: ");
        double salary = double.Parse(Console.ReadLine());

        if (salary < 0)
        {
            throw new ArgumentException("Salary cannot be negative");
        }
        
        Console.WriteLine("Employee Created Successefully! ");
        
        Employee employee = new Employee (employeeId, firstName, lastName, middleName, salary);
        
        Console.WriteLine("Employee Details: " + "Employee ID: " + employee.EmployeeId + " " + "Employee Name:  " + employee.DisplayEmployeeInfo());

        Console.WriteLine("Department: ");
        string department = Console.ReadLine();
        
        if (department == "Human Resources")
        {
            Console.WriteLine(hrDepartment.GetDepartmentDetails());
            hrDepartment.Operate();
        }
       
        
        
        Console.WriteLine("Department: ");
        department = Console.ReadLine();
        
        if (department == "IT")
        {
            Console.WriteLine(itDepartment.GetDepartmentDetails());
            itDepartment.Operate();
        }
        
      
       
        
        
        
    }
}