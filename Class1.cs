using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab6
{
    public abstract partial class IntelligentCreature
    {
        public string date { get; set; }
        public virtual void Display()
        {
        }
    }
}
