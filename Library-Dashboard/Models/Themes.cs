using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Themes : BaseEntity
{
    public string? Name { get; set; }
    public List<Books> Books { get; set; }
}
