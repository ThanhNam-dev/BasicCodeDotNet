﻿using System;
using System.Collections.Generic;

namespace BasicCodeDotNet.Models.Entities;

public partial class Category
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
