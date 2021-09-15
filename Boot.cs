using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8
{
    class Boot
    {
    public virtual void starten()
        {

        }
    }

    class SpeedBoot : Boot
    {
        public override void starten()
        {
            Console.WriteLine("Ik zet even mijn pet af");
        }

    }
}
