using System.Collections.Generic;

namespace Library_Dashboard.Models;

public class Books : BaseEntity
{
    public string Name { get; set; }
    public int Pages { get; set; }
    public int YearPress { get; set; }
    public int Id_Themes { get; set; }
    public int Id_Category { get; set; }
    public int Id_Author { get; set; }
    public int Id_Press { get; set; }
    public string? Comment { get; set; }
    public int Quantity { get; set; }
    public Themes Theme { get; set; }
    public Categories Categories { get; set; }
    public Press Press { get; set; }
    public Author Authors { get; set; }

    public ICollection<S_Cards> S_Cards { get; set; } 
    public ICollection<T_Cards> T_Cards { get; set; } 
    
}
