using AutoMapper;
using DatingApp.Application.ViewModel;
using DatingApp.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<SampleViewModel, CreateSampleCommand>()
                .ConstructUsing(c => new CreateSampleCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
