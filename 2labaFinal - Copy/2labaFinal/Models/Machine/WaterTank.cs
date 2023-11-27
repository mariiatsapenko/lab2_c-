﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.Machine
{
    public class WaterTank
    {
        public double Volume { get; set; }

        public WaterTank(double volume)
        {
            Volume = volume;
        }

        public void TakeWater(double volume)
        {
            if (Volume < volume)
            {
                throw new Exception("Недостатньо води в баку!");
            }
            Volume -= volume;
        }

        public void PutWater(double volume)
        {
            Volume += volume;
        }
    }
}
