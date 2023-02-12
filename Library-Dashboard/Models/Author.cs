using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Author : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Books>? Books { get; set; }

}
