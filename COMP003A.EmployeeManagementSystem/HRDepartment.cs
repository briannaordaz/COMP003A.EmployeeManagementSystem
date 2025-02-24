namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// derived class to override GetDepartmentDetails()
/// </summary>
public class HRDepartment : Department, IDepartmentOperartions

{
    /// <summary>
    ///  method that was overriden
    /// </summary>
    /// <returns></returns>
    public override string GetDepartmentDetails()
    {
        return "Details: Handles employee relations and recruitmemt. ";
    }

    /// <summary>
    /// method from interface class
    /// </summary>
    public void Operate()
    {
        Console.WriteLine("Performing HR operations... ");
    }
}