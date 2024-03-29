﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices_dz_8
{
    public abstract class Device
    {
        protected string _name;

        public Device(string name)
        {
            _name = name;
        }

        public abstract void Sound();

        public virtual void Show()
        {
            Console.WriteLine($"Название устройства: {_name}");
        }
        public abstract void Desc();
    }
}
