using DatingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.Domain.Interfaces
{
    public interface ISampleRepository
    {
        IQueryable<Sample> GetCourses();
        void Add(Sample course);
    }
}
