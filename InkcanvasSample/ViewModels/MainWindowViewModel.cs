using System.Windows.Input;
using InkcanvasSample.Views;
using Prism.Commands;

namespace InkcanvasSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            this.SelectProjectCommand = new DelegateCommand(this.SelectProject);
        }

        public ICommand SelectProjectCommand { get; }

        public void SelectProject()
        {
            var dialog = new SelectProjectView();
            dialog.ShowDialog();
        }
    }
}
