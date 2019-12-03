using MyStore.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Core.Commands
{
    public abstract class Command:Message
    {
        public DateTime Time { get;protected set; }
        protected Command()
        {
            Time = DateTime.Now;
        }
    }
}
