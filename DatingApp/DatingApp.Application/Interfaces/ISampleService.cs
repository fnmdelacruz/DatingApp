using DatingApp.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Application.Interfaces
{
    public interface ISampleService
    {
        IEnumerable<SampleViewModel> GetCourses();

        void Create(SampleViewModel courseViewModel);
    }
}
