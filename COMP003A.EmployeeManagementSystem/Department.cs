namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// public abstract class for department
/// </summary>
public abstract class Department
{
    public string DepartmentName { get; set; }

    /// <summary>
    /// an abstract method 
    /// </summary>
    /// <returns></returns>
    public abstract string GetDepartmentDetails();
    
    /// <summary>
    /// a concrete method that prints department name
    /// </summary>
    /// <returns></returns>
    public  string DisplayDepartmentInfo()
    {
        return DepartmentName;
    }

}