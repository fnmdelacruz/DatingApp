using AutoMapper;
using DatingApp.Application.ViewModel;
using DatingApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Sample, SampleViewModel>();
        }
    }
}
