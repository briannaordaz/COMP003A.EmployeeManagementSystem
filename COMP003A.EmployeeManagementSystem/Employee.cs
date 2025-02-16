namespace COMP003A.EmployeeManagementSystem;

public class Employee
{
    private string _employeeId;
    private string _firstName;
    private string _middleName;
    private string _lastName;
    private double _salary;

    public string EmployeeId
    {
        get { return _employeeId; }
        
    }

    public string FirstName
    {
        get { return _firstName; }
        set { if (!string.IsNullOrWhiteSpace(value)) _firstName = value; }
    }

    public string MiddleName
    {
        get { return _middleName; }
        set { if (string.IsNullOrWhiteSpace(value)) _middleName = value; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { if (!string.IsNullOrWhiteSpace(value)) _lastName = value; }
        
    }

    public double Salary
    {
        get { return _salary; }
        set
        {
            if (value > 0)
            {
                _salary = value;
            }
            throw new ArgumentException("Salary must be greater than 0");
        }
        
    }
    
    
    
}