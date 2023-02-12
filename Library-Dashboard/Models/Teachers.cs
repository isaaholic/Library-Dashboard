using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Teachers : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id_Dep { get; set; }

    public Departments Departments { get; set; }

    public ICollection<T_Cards> T_Cards { get; set; }
}
