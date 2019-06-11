using System.Windows;
using InkcanvasSample.ViewModels;

namespace InkcanvasSample.Views
{
    /// <summary>
    /// Interaction logic for SelectProjectView.xaml
    /// </summary>
    public partial class SelectProjectView : Window
    {
        public SelectProjectView()
        {
            InitializeComponent();

            this.DataContext = new SelectProjectViewModel();
        }
    }
}
