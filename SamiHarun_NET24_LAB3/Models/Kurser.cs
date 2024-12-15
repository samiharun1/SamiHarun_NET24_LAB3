using System;
using System.Collections.Generic;

namespace SamiHarun_NET24_LAB3.Models;

public partial class Kurser
{
    public int Id { get; set; }

    public string? Kursnamn { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();
}
