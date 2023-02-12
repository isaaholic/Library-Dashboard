using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Group : BaseEntity
{
    public string Name { get; set; }
    public int Id_Faculty { get; set; }

    public Faculties? Faculties { get; set; }
    public ICollection<Students>? Students { get; set; }
}
