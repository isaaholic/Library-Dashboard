using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Departments : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Teachers> Teacher { get; set; } 
}
