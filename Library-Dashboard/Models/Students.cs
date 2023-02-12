using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Students : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Group { get; set; }
    public Group? Group { get; set; }

    public ICollection<S_Cards> S_Cards { get; set; }
}
