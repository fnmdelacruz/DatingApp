using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Domain.Commands
{
    public class CreateSampleCommand : SampleCommand
    {
        public CreateSampleCommand(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
