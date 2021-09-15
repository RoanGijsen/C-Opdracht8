using System;

namespace Csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Kapitein kapitein = new Kapitein();
            Boot boot = new Boot();
            SpeedBoot boot2 = new SpeedBoot();
            Boot boot3 = new SpeedBoot();

            kapitein.varen(boot);
            kapitein.varen(boot2);
            kapitein.varen(boot3);
        }
    }
}
