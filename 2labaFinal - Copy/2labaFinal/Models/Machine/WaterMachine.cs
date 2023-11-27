using _2labaFinal.Interfaces;
using _2labaFinal.Models.PaymentStrategy;
using _2labaFinal.Models.WaterModels;
using _2labaFinal.Types;
using System;

namespace _2labaFinal.Models.Machine
{
    public class WaterMachine
    {
        public string Address = "empty";
        private IPay _paymentStrategy;
        public readonly MoneyPayment CashPaymentStrategy = new MoneyPayment();
        public readonly CardPayment CardPaymentStrategy = new CardPayment();
        private Water _selectedWater;
        private WaterVendingMachine _waterVendingMachine;
        public WaterTank WaterTank;
        public readonly double _stillWaterPrice = 25;
        public readonly double _sodaWaterPrice = 20;
        private readonly double _waterTankMaxVolume = 10000;
        public int BottleCount = 0;
        private const double BottleVolume = 2;
        private double _waterVolume;
        private int _bottleBuyedCount = 0;
        public double Income = 0;
        public bool PayWithCard = false;
        public bool SellBottles = false;
        public bool SellSoda = false;

        public WaterMachine() {
            WaterTank = new WaterTank(_waterTankMaxVolume);
            _waterVendingMachine = new WaterVendingMachine(null, null);
        }

        public WaterMachine(double stillWaterPrice, double sodaWaterPrice, double waterTankMaxVolume, int bottleCount, string address)
        {
            _stillWaterPrice = stillWaterPrice;
            _sodaWaterPrice = sodaWaterPrice;
            _waterTankMaxVolume = waterTankMaxVolume;
            BottleCount = bottleCount;
            _waterVendingMachine = new WaterVendingMachine(null, null);
            WaterTank = new WaterTank(waterTankMaxVolume);
            Address = address;
        }

        public bool SelectPaymentStrategy(PaymentType payment)
        {
            switch (payment)
            {
                case PaymentType.Card:
                    if (!PayWithCard)
                    {
                        throw new InvalidOperationException("Оплата картою неможлива!");
                    }
                    _paymentStrategy = CardPaymentStrategy;
                    break;
                case PaymentType.Money:
                    _paymentStrategy = CashPaymentStrategy;
                    break;
                default:
                    return false;
            }

            _waterVendingMachine.SetPaymentStrategy(_paymentStrategy);
            return true;
        }

        public bool SelectWater(WaterType type)
        {
            switch (type)
            {
                case WaterType.Soda:
                    if(!SellSoda)
                    {
                        throw new InvalidOperationException("Газована вода не продається ");
                    }
                    _selectedWater = new SodaWater(_sodaWaterPrice);
                    break;
                case WaterType.Still:
                    _selectedWater = new StillWater(_stillWaterPrice);
                    break;
                default:
                    return false;
            }

            return true;
        }

        public bool BuyWithBottles(int bottleCount)
        {
            if(SellBottles)
            {
                if (bottleCount > BottleCount)
                {
                    throw new ArgumentException("Недостатньо пляшок в автоматі");
                }
                if (bottleCount * BottleVolume > WaterTank.Volume)
                {
                    throw new ArgumentException("Недостатньо води в баку!");
                }
                _bottleBuyedCount = bottleCount;
                _waterVolume = bottleCount * BottleVolume;
                _waterVendingMachine.SetWater(new Bottle(_selectedWater, bottleCount));
                return true;
            }
            throw new InvalidOperationException("Пляшки зараз не продаються!");
        }

        public bool BuyWithVolume(double volume)
        {
            if (volume > WaterTank.Volume)
            {
                throw new ArgumentException("Недостатньо води в баку!");
            }
            _waterVolume = volume;
            _waterVendingMachine.SetWater(new WaterByVolume(_selectedWater, volume));
            return true;
        }

        public bool BuyWater()
        {
            if (_waterVendingMachine.BuyWater())
            {
                BottleCount -= _bottleBuyedCount;
                WaterTank.TakeWater(_waterVolume);
                _bottleBuyedCount = 0;
                _waterVolume = 0;
                Income += GetCost();
                return true;
            };
            _bottleBuyedCount = 0;
            _waterVolume = 0;
            return false;
        }

        public double GetCost()
        {
            return _waterVendingMachine.GetCost();
        }
    }
}
