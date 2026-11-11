using System;
using System.Collections.Generic;

namespace Lab7.Models;

public partial class Material
{
    public short MaterialId { get; set; }

    public string Name { get; set; } = null!;

    public int? TypeFk { get; set; }

    public byte? UnitFk { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual MaterialType? TypeFkNavigation { get; set; }

    public virtual Unit? UnitFkNavigation { get; set; }
}
