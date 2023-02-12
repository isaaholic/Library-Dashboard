using System;

namespace Library_Dashboard.Models;

public class T_Cards : BaseEntity
{
    public int Id_Teacher { get; set; }
    public int Id_Lib { get; set; }
    public int Id_Book { get; set; }
    public DateTime? DateIn { get; set; }
    public DateTime DateOut { get; set; }

    public Teachers? Teachers { get; set; }
    public Books? Book { get; set; }
    public Libs? Lib { get; set; }
}
