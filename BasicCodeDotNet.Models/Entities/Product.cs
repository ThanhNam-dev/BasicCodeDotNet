using System;
using System.Collections.Generic;

namespace BasicCodeDotNet.Models.Entities;

public partial class Product
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? Category { get; set; }

    public virtual Category? CategoryNavigation { get; set; }
}
