using Library_Dashboard.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library_Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LibraryDbContext? context = null;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            context = new LibraryDbContext();
        }


        private async void ListViewClickAsync(object sender, MouseButtonEventArgs e)
        {
            DataGrid.ItemsSource = null;
            DataGrid.Items.Clear();

            if (sender is ListViewItem viewItem)
            {
                switch (viewItem.Name)
                {
                    case "Categories":
                        {
                            var list = await context.Categories.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name });
                        }
                        break;
                    case "Authors":
                        {

                            var list = await context.Authors.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName });
                        }
                        break;
                    case "Books":
                        {
                            var list = await context.Books.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name, x.YearPress, x.Pages, x.Id_Press, x.Id_Author, x.Id_Category, x.Id_Themes });
                        }
                        break;
                    case "Students":
                        {
                            var list = await context.Students.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName, x.Id_Group });
                        }
                        break;
                    case "SCards":
                        {
                            var list = await context.S_Cards.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Id_Lib, x.Id_Student, x.DateIn, x.DateOut });
                        }
                        break;
                    case "Press":
                        {
                            var list = await context.Press.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name });
                        }
                        break;
                    case "Groups":
                        {
                            var list = await context.Groups.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name, x.Id_Faculty });
                        }
                        break;
                    case "Teachers":
                        {
                            var list = await context.Teachers.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName, x.Id_Dep });
                        }
                        break;
                    case "Departments":
                        {
                            var list = await context.Departments.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name });
                        }
                        break;
                    case "Themes":
                        {
                            var list = await context.Themes.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name });
                        }
                        break;
                    case "Libs":
                        {
                            var list = await context.Libs.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.FirstName, x.LastName });
                        }
                        break;
                    case "Faculties":
                        {
                            var list = await context.Faculties.ToListAsync();
                            DataGrid.ItemsSource = list.Select(x => new { x.Id, x.Name });
                        }
                        break;
                    case "TCards":
                        {
                            var list2 = await context.T_Cards.ToListAsync();
                            DataGrid.ItemsSource = list2.Select(x => new { x.Id, x.Id_Lib, x.Id_Teacher, x.DateIn, x.DateOut });
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
