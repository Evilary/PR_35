using System;
using System.Windows;
using System.Windows.Controls;

namespace PermDynamics_Chernyshkov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public Main(MainWindow mainWindow)
        {
            InitializeComponent();
        }

        private void OpenPageChart(object sender, RoutedEventArgs e)
        {
            float value = Convert.ToInt32(tb_value.Text);

            MainWindow.mainWindow.pointsInfo.Add(new Classes.PointInfo(value));
            MainWindow.mainWindow.OpenPages(MainWindow.pages.chart);
        }

    }
}
