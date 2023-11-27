using _2labaFinal.Types;
using _2labaFinal.Models.Machine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2labaFinal
{
    public partial class Form1 : Form
    {
        private int _formStage = 0;
        public string AutomatAdress { get; set; }
        private WaterMachine _waterMachine;

        public Form1(WaterMachine waterMachine)
        {
            _waterMachine = waterMachine;
            AutomatAdress = _waterMachine.Address;
            InitializeComponent();
            btnWaterTypeSoda.Enabled = _waterMachine.SellSoda;
            btnWithoutBottle.Enabled = _waterMachine.SellBottles;
            btnWithCard.Enabled = _waterMachine.PayWithCard;

            redrawWindow();
        }
        
        private void redrawWindow()
        {


            labelWaterInMachine.Text = "Кількість води (л): " + _waterMachine.WaterTank.Volume.ToString();
            labelBottlesCount.Text = "Кількість пляшок: " + _waterMachine.BottleCount.ToString();
            labelBottlePrice.Text = "Пляшка (2л): 1,25";
            labelSodaPrice.Text = "Газована: " + _waterMachine._sodaWaterPrice.ToString();
            labelStillWaterPrice.Text = "Негазована: " + _waterMachine._stillWaterPrice.ToString();

            labelWaterAdd.Visible = false;
            labelBottleAdd.Visible = false;
            textBoxBottleAdd.Visible = false;
            textBoxWaterAdd.Visible = false;
            btnAddWater.Visible = false;
            btnBuy.Visible = false;
            labelCountOfLiters.Visible = false;
            textBoxCountOfLiters.Visible = false;
            btnWithBottle.Visible = false;
            btnBuy.Visible = false;
            labelCountOfBottles.Visible = false;
            textBoxCountOfBottles.Visible = false;
            btnWithoutBottle.Visible=false;
            labelOwnBottle.Visible = false;
            btnBack.Visible = false;
            btnWaterTypeSoda.Visible = false;
            btnWaterTypeStill.Visible = false;
            labelWaterType.Visible = false;
            btnCash.Visible = false;
            btnWithCard.Visible = false;
            labelPayMehod.Visible = false;
            labelSum.Visible = false;
            labelCacheAmount.Visible = false;
            textBoxCashAmount.Visible = false;
            btnPay.Visible = false;

            btnBack.Visible = true;
            switch (_formStage)
            {
                case 0:
                    btnBack.Visible = false;
                    btnWaterTypeSoda.Visible = true;
                    btnWaterTypeStill.Visible = true;
                    labelWaterType.Visible = true;
                    break;
                case 1:
                    btnWithBottle.Visible = true;
                    btnWithoutBottle.Visible = true;
                    labelOwnBottle.Visible = true;
                    break;
                case 2:
                    btnBuy.Visible = true;
                    labelCountOfBottles.Visible = true;
                    textBoxCountOfBottles.Visible = true;
                    break;
                case 3:

                    btnBuy.Visible = true;
                    labelCountOfLiters.Visible = true;
                    textBoxCountOfLiters.Visible = true;
                    break;
                case 4:
                    btnCash.Visible = true;
                    btnWithCard.Visible = true;
                    labelPayMehod.Visible = true;
                    labelSum.Visible = true;
                    break;
                case 5:
                    labelSum.Visible = true;
                    labelCacheAmount.Visible = true;
                    textBoxCashAmount.Visible = true;
                    btnPay.Visible = true;
                    break;

            }
        }

        private void btnWaterTypeSoda_Click(object sender, EventArgs e)
        {
            _formStage = 1;
            _waterMachine.SelectWater(WaterType.Soda);
            redrawWindow();
        }

        private void btnWaterTypeStill_Click(object sender, EventArgs e)
        {
            _formStage = 1;
            _waterMachine.SelectWater(WaterType.Still);
            redrawWindow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_formStage == 2 || _formStage == 3)
            {
                _formStage = 1;
            } else
            {
                _formStage--;
            }

            redrawWindow();
        }

        private void btnWithoutBottle_Click(object sender, EventArgs e)
        {
            _formStage = 2;
            redrawWindow();
        }

        private void btnWithBottle_Click(object sender, EventArgs e)
        {
            _formStage = 3;
            redrawWindow();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                if (_formStage == 2)
                {
                    var count = int.Parse(textBoxCountOfBottles.Text);
                    if (count <= 0)
                    {
                        throw new Exception("Кількість пляшок має бути більше 0");
                    }
                    _waterMachine.BuyWithBottles(count);
                }
                else
                {
                    var volume = double.Parse(textBoxCountOfLiters.Text);
                    if (volume <= 0)
                    {
                        throw new Exception("Об'єм води повинен бути більше 0");
                    }
                    _waterMachine.BuyWithVolume(volume);
                }
                labelSum.Text = "Cума: " + _waterMachine.GetCost().ToString();
                _formStage = 4;
                redrawWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            _formStage = 5;
            _waterMachine.SelectPaymentStrategy(PaymentType.Money);
            redrawWindow();
        }

        private void btnWithCard_Click(object sender, EventArgs e)
        {
            _waterMachine.SelectPaymentStrategy(PaymentType.Card);
            _waterMachine.BuyWater();
            _formStage = 0;
            MessageBox.Show("Ви купили воду!");
            
            redrawWindow();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                var cash = double.Parse(textBoxCashAmount.Text);
                if (cash <= 0)
                {
                    throw new Exception("Гроші мають бути більше 0!");
                }
                _waterMachine.CashPaymentStrategy.PutCash(cash);
                _waterMachine.BuyWater();
                _formStage = 0;
                MessageBox.Show("Ви купили воду!");
                var change = _waterMachine.CashPaymentStrategy.TakeChange();
                if (change > 0)
                {
                    MessageBox.Show("Ваша здача: " + change.ToString());
                }
                redrawWindow();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void getAdressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_waterMachine.Address);
        }

        private void getIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_waterMachine.Income.ToString());
        }

        private void addBottlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBuy.Visible = false;
            labelCountOfLiters.Visible = false;
            textBoxCountOfLiters.Visible = false;
            btnWithBottle.Visible = false;
            btnBuy.Visible = false;
            labelCountOfBottles.Visible = false;
            textBoxCountOfBottles.Visible = false;
            btnWithoutBottle.Visible = false;
            labelOwnBottle.Visible = false;
            btnBack.Visible = false;
            btnWaterTypeSoda.Visible = false;
            btnWaterTypeStill.Visible = false;
            labelWaterType.Visible = false;
            btnCash.Visible = false;
            btnWithCard.Visible = false;
            labelPayMehod.Visible = false;
            labelSum.Visible = false;
            labelCacheAmount.Visible = false;
            textBoxCashAmount.Visible = false;
            btnPay.Visible = false;

            labelWaterAdd.Visible = true;
            labelBottleAdd.Visible = true;
            textBoxBottleAdd.Visible = true;
            textBoxWaterAdd.Visible = true;
            btnAddWater.Visible = true;
        }

        private void btnAddWater_Click(object sender, EventArgs e)
        {
            try
            {
                var addBottle = int.Parse(textBoxBottleAdd.Text);
                var addWater = int.Parse(textBoxWaterAdd.Text);
                if (addBottle < 0 || addWater < 0)
                {
                    throw new Exception("Доданий обсяг повинен бути позитивним!");
                }


                _waterMachine.BottleCount += addBottle;
                _waterMachine.WaterTank.Volume += addWater;
                redrawWindow();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelWaterAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
