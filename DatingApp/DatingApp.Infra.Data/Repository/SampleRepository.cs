using DatingApp.Domain.Interfaces;
using DatingApp.Domain.Models;
using DatingApp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.Infra.Data.Repository
{
    public class SampleRepository : ISampleRepository
    {
        private SampleDBContext _ctx;

        public SampleRepository(SampleDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Sample sample)
        {
            _ctx.Samples.Add(sample);
            _ctx.SaveChanges();
        }

        public IQueryable<Sample> GetCourses()
        {
            return _ctx.Samples;
        }
    }
}
