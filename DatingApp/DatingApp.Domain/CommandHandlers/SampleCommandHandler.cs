using DatingApp.Domain.Commands;
using DatingApp.Domain.Interfaces;
using DatingApp.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatingApp.Domain.CommandHandlers
{
    public class SampleCommandHandler : IRequestHandler<CreateSampleCommand, bool>
    {
        private readonly ISampleRepository _courseRepository;
        public SampleCommandHandler(ISampleRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Task<bool> Handle(CreateSampleCommand request, CancellationToken cancellationToken)
        {
            var course = new Sample()
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl
            };

            _courseRepository.Add(course);

            return Task.FromResult(true);
        }
    }
}
