using DatingApp.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Domain.Commands
{
    public abstract class SampleCommand : Command
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ImageUrl { get; protected set; }
    }
}
