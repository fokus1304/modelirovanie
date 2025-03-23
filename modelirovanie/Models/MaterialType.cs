﻿using System;
using System.Collections.Generic;

namespace modelirovanie.Models;

public partial class MaterialType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
