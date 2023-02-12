using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Categories : BaseEntity
{
    public string Name { get; set;}
    public ICollection<Books> Books{ get; set;}
}
