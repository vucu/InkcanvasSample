using System.Collections.ObjectModel;
using System.Linq;
using InkcanvasSample.Common;
using InkcanvasSample.Models;

namespace InkcanvasSample.ViewModels
{
    public class SelectProjectViewModel : ViewModelBase
    {
        public SelectProjectViewModel()
        {
            this.Projects = new ObservableCollection<Project>(Globals.SampleProjectData);
        }

        public ObservableCollection<Project> Projects { get; }

        public Project SelectedProject
        {
            get
            {
                return Projects.FirstOrDefault(x => Globals.CurrentProjectId == x.Id);
            }

            set {
                Globals.CurrentProjectId = value.Id;
                OnPropertyChanged(nameof(SelectedProject));
            }
        }
    }
}
