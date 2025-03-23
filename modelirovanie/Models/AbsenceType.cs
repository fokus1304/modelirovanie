using System;
using System.Collections.Generic;

namespace modelirovanie.Models;

public partial class AbsenceType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Absence> Absences { get; set; } = new List<Absence>();
}
