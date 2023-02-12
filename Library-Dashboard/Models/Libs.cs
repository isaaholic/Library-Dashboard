using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Libs : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<S_Cards> S_Cards { get; set; }
    public ICollection<T_Cards> T_Cards { get; set; }
}
