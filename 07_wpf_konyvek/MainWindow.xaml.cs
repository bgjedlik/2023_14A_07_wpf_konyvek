using System;
using System.Collections.Generic;
using System.IO;
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

namespace _07_wpf_konyvek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();
            loadBooks();
        }

        private void loadBooks()
        {
            foreach (var row in File.ReadAllLines("booklist.csv").Skip(1))
            {
                books.Add(new Book(row));
            }
        }
    }
}
