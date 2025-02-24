namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// derived class to override GetDepartmentDetails()
/// </summary>
public class ITDepartment : Department, IDepartmentOperartions
{
    /// <summary>
    /// Method that was overriden
    /// </summary>
    /// <returns></returns>
    public override string GetDepartmentDetails()
    {
        return "Details: Manages technical resources and infrastructure.";
    }

    /// <summary>
    /// method from interface class
    /// </summary>
    public void Operate()
    {
        Console.WriteLine("Performing IT operations... ");
    }
}