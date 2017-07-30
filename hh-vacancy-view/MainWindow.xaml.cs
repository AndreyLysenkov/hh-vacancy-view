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
using Vacancy.Core.ViewModel;

namespace hh_vacancy_view
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel m = (ViewModel)DataContext;
            string response = $"key words: {m.KeyWords}\n";
            response += $"work experience: {m.WorkExperience.ToString()}\n";
            response += $"search restricted by town only: {m.IsTownOnly.ToString()}\n";
            System.IO.File.WriteAllText("fields state.txt", response);
        }

    }
}
