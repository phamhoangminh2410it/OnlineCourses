using System.ComponentModel.DataAnnotations.Schema;

namespace Organic.Models;

//Default Departments

[Table("Department")]
public class Department
{
    public short DepartmentId { get; set; }
    public string DepartmentName { get; set; } = null!;
}