﻿using System;
using System.Collections.Generic;

namespace modelirovanie.Models;

public partial class EducationType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Education> Educations { get; set; } = new List<Education>();
}
