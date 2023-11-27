﻿using _2labaFinal.Interfaces;
using _2labaFinal.Models.WaterModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2labaFinal.Models.Machine
{
    public class WaterVendingMachine
    {
        private IPay _paymentStrategy;
        private Water _water;

        public WaterVendingMachine(IPay paymentStrategy, Water water)
        {
            _paymentStrategy = paymentStrategy;
            _water = water;
        }

        public bool BuyWater()
        {
            double cost = _water.GetCost();
            return _paymentStrategy.Pay(cost);
        }

        public void SetPaymentStrategy(IPay paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetWater(Water water)
        {
            _water = water;
        }

        public double GetCost()
        {
            return _water.GetCost();
        }

    }
}
