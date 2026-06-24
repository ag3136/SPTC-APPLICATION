using System.Windows;
using System.Windows.Controls;
using SPTC_APPLICATION.View;

namespace SPTC_APPLICATION.View.Pages.FranchiseModule
{
    /// <summary>
    /// Interaction logic for Franchise.xaml
    /// </summary>
    public partial class FranchiseWindow : Window
    {
        public FranchiseWindow()
        {
            InitializeComponent();
        }

        private void Franchise_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnGererate_Click(object sender, RoutedEventArgs e)
        {
            new GenerateID().Show();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            new Test().Show();
        }
    }
}
