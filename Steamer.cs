using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_dz_8
{
    public class Steamer : Device
    {
        private int _displacement;

        public Steamer(string name, int displacement) : base(name)
        {
            _displacement = displacement;
        }

        public override void Sound()
        {
            Console.WriteLine("Пароход гудит!");
        }

        public override void Desc()
        {
            Console.WriteLine($"Пароход {_name} водоизмещением {_displacement} тонн.");
        }
    }

}
