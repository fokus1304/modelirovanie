using System;
using System.Collections.Generic;

namespace modelirovanie.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int? DepartmentDirector { get; set; }

    public int? IdMainpepartment { get; set; }

    public virtual Employee? DepartmentDirectorNavigation { get; set; }

    public virtual ICollection<Department> LowerDeps { get; set; } = new List<Department>();

    public virtual ICollection<Department> MainDeps { get; set; } = new List<Department>();
}
