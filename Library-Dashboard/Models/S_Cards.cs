using System;

namespace Library_Dashboard.Models;

public class S_Cards : BaseEntity
{
    public int Id_Student { get; set; }
    public int Id_Lib { get; set; }
    public int Id_Book { get; set; }
    public DateTime? DateIn { get; set; }
    public DateTime DateOut { get; set; }

    public Students? Student { get; set; }
    public Books? Book { get; set; }
    public Libs? Lib { get; set; }
}
