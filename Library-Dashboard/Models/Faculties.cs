
using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Faculties : BaseEntity
{
    public string Name { get; set; }
    public ICollection<Group> Group { get; set; }
}
