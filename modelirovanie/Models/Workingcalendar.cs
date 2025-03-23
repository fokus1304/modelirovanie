using System;
using System.Collections.Generic;

namespace modelirovanie.Models;

public partial class Workingcalendar
{
    public int Id { get; set; }

   
    public DateOnly Exceptiondate { get; set; }

   
    public bool Isworkingday { get; set; }

    public virtual ICollection<Employee> IdEmployees { get; set; } = new List<Employee>();
}
