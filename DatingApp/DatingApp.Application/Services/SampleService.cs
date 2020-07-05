using AutoMapper;
using AutoMapper.QueryableExtensions;
using DatingApp.Application.Interfaces;
using DatingApp.Application.ViewModel;
using DatingApp.Domain.Commands;
using DatingApp.Domain.Core.Bus;
using DatingApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Application.Services
{
    public class SampleService : ISampleService
    {

        private readonly ISampleRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;
        public SampleService(ISampleRepository courseRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = autoMapper;
        }

        public void Create(SampleViewModel sampleViewModel)
        {
            _bus.SendCommand(_autoMapper.Map<CreateSampleCommand>(sampleViewModel));
        }

        public IEnumerable<SampleViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<SampleViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
