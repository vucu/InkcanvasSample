using System.Collections.Generic;
using InkcanvasSample.Models;

namespace InkcanvasSample.Common
{
    public static class Globals
    {
        static Globals()
        {
            SampleProjectData = new List<Project>
            {
                new Project {Id = 1, Count = 3},
                new Project {Id = 2, Count = 6},
                new Project {Id = 3, Count = 10}
            };
            CurrentProjectId = SampleProjectData[0].Id;
        }

        public static IReadOnlyList<Project> SampleProjectData { get; }

        public static int CurrentProjectId { get; set; }
    }
}
