using System.Reflection.Metadata;

namespace COMP003A.EmployeeManagementSystem;
/// <summary>
/// Employee class with Encapsulation
/// </summary>
public class Employee
{
    /// <summary>
    /// private fields for employee ID, first name, middle name, last name, and salary
    /// </summary>
    private string _employeeId;
    private string _firstName;
    private string _middleName = string.Empty;
    private string _lastName;
    private double _salary;

    /// <summary>
    /// Public property for employeeID
    /// </summary>
    public string EmployeeId
    {
        get { return _employeeId; }
        
    }
    

    /// <summary>
    /// public property for first name
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public string FirstName
    {
        get { return _firstName; }
        set {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _firstName = value;
            } 
            else throw new ArgumentException("First name cannot be empty");
        }
    }

    /// <summary>
    /// public property for middle name
    /// </summary>
    public string MiddleName
    {
        get { return _middleName; }
        set { _middleName = value ?? string.Empty;  }
    }

    /// <summary>
    /// public property for last name 
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public string LastName
    {
        get { return _lastName; }
        set {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _lastName = value;
                
            } 
            else throw new ArgumentException("Last name cannot be empty");
        }
        
    }

    /// <summary>
    /// public property for salary
    /// </summary>
    /// <exception cref="ArgumentException"></exception>
    public double Salary
    {
        get { return _salary; } 
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary needs to be greater than 0");
            }
           else _salary = value;
        }
        
    }

    /// <summary>
    /// constructor that initializes fields
    /// </summary>
    /// <param name="employeeId"></param>
    /// <param name="firstName"></param>
    /// <param name="lastName"></param>
    /// <param name="middleName"></param>
    /// <param name="salary"></param>
    public Employee(string employeeId, string firstName, string lastName, string middleName, double salary)
    {
        _employeeId = employeeId;
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName ?? string.Empty;
        Salary = salary;
       
        

    }

    /// <summary>
    /// method for first and last name only
    /// </summary>
    /// <returns></returns>
    public string FirstAndLastname()
    {
        return FirstName + " " + LastName;
    }
    
    /// <summary>
    /// method for first, middle, and last names
    /// </summary>
    /// <returns></returns>
    public string PrintFullName()
    {
        if (string.IsNullOrWhiteSpace(MiddleName))
        {
            return FirstAndLastname();
        }
        return FirstName + " " + MiddleName + " " + LastName;
    }

    /// <summary>
    /// method to display info: full name + salary
    /// </summary>
    /// <returns></returns>
    public string DisplayEmployeeInfo()
    {
        if (string.IsNullOrWhiteSpace(_middleName))
        {

            return FirstAndLastname() + " " + Salary;
        }
        else return PrintFullName() + " " + Salary;

    }
    
    
    
    
}