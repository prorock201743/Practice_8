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

namespace Practice_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CompareLastName_Click(object sender, RoutedEventArgs e)
        {
            FamilyWorker firstWorker = new FamilyWorker(NameW1.Text, LastNameW1.Text, PatronymicW1.Text);
            FamilyWorker secondWorker = new FamilyWorker(NameW2.Text, LastNameW2.Text, PatronymicW2.Text);

            bool answer = firstWorker.CompareTo(secondWorker);
            if (answer == true) result.Text = "Фамилии равны";
            if (answer == false) result.Text = "Фамилии не равны";
        }

        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            FamilyWorker worker = new FamilyWorker(NameW1.Text, LastNameW1.Text, PatronymicW1.Text);
            result.Text = worker.ShowInfoOfWorker();
        }

        private void GetInfoOfFatherWorker_Click(object sender, RoutedEventArgs e)
        {
            FamilyWorker worker = new FamilyWorker(NameW2.Text, LastNameW2.Text, PatronymicW2.Text);
            result.Text = worker.ShowInfoOfFamilyWorker();
        }

        private void GetDeveloperInformation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Золотарев М. А.\n Группа: ИСП-34\n Вариант №13", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
