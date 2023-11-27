namespace _2labaFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWaterType = new System.Windows.Forms.Label();
            this.btnWaterTypeStill = new System.Windows.Forms.Button();
            this.btnWaterTypeSoda = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelOwnBottle = new System.Windows.Forms.Label();
            this.btnWithoutBottle = new System.Windows.Forms.Button();
            this.btnWithBottle = new System.Windows.Forms.Button();
            this.textBoxCountOfBottles = new System.Windows.Forms.TextBox();
            this.labelCountOfBottles = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.labelCountOfLiters = new System.Windows.Forms.Label();
            this.textBoxCountOfLiters = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelPayMehod = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnWithCard = new System.Windows.Forms.Button();
            this.labelWaterInMachine = new System.Windows.Forms.Label();
            this.labelCacheAmount = new System.Windows.Forms.Label();
            this.textBoxCashAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addBottlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAdressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBottlesCount = new System.Windows.Forms.Label();
            this.labelStillWaterPrice = new System.Windows.Forms.Label();
            this.labelSodaPrice = new System.Windows.Forms.Label();
            this.labelBottlePrice = new System.Windows.Forms.Label();
            this.labelPrices = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnAddWater = new System.Windows.Forms.Button();
            this.textBoxWaterAdd = new System.Windows.Forms.TextBox();
            this.labelWaterAdd = new System.Windows.Forms.Label();
            this.textBoxBottleAdd = new System.Windows.Forms.TextBox();
            this.labelBottleAdd = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWaterType
            // 
            this.labelWaterType.AutoSize = true;
            this.labelWaterType.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterType.ForeColor = System.Drawing.Color.Black;
            this.labelWaterType.Location = new System.Drawing.Point(393, 128);
            this.labelWaterType.Name = "labelWaterType";
            this.labelWaterType.Size = new System.Drawing.Size(162, 40);
            this.labelWaterType.TabIndex = 2;
            this.labelWaterType.Text = "Тип води";
            // 
            // btnWaterTypeStill
            // 
            this.btnWaterTypeStill.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterTypeStill.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWaterTypeStill.Location = new System.Drawing.Point(259, 192);
            this.btnWaterTypeStill.Name = "btnWaterTypeStill";
            this.btnWaterTypeStill.Size = new System.Drawing.Size(141, 42);
            this.btnWaterTypeStill.TabIndex = 4;
            this.btnWaterTypeStill.Text = "Газована:";
            this.btnWaterTypeStill.UseVisualStyleBackColor = true;
            this.btnWaterTypeStill.Click += new System.EventHandler(this.btnWaterTypeStill_Click);
            // 
            // btnWaterTypeSoda
            // 
            this.btnWaterTypeSoda.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterTypeSoda.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWaterTypeSoda.Location = new System.Drawing.Point(486, 190);
            this.btnWaterTypeSoda.Name = "btnWaterTypeSoda";
            this.btnWaterTypeSoda.Size = new System.Drawing.Size(141, 42);
            this.btnWaterTypeSoda.TabIndex = 5;
            this.btnWaterTypeSoda.Text = "Негазована";
            this.btnWaterTypeSoda.UseVisualStyleBackColor = true;
            this.btnWaterTypeSoda.Click += new System.EventHandler(this.btnWaterTypeSoda_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SlateGray;
            this.btnBack.Location = new System.Drawing.Point(169, 191);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<=";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelOwnBottle
            // 
            this.labelOwnBottle.AutoSize = true;
            this.labelOwnBottle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwnBottle.ForeColor = System.Drawing.Color.Black;
            this.labelOwnBottle.Location = new System.Drawing.Point(298, 126);
            this.labelOwnBottle.Name = "labelOwnBottle";
            this.labelOwnBottle.Size = new System.Drawing.Size(361, 40);
            this.labelOwnBottle.TabIndex = 7;
            this.labelOwnBottle.Text = "У вас є своя пляшка?";
            this.labelOwnBottle.Visible = false;
            // 
            // btnWithoutBottle
            // 
            this.btnWithoutBottle.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithoutBottle.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWithoutBottle.Location = new System.Drawing.Point(259, 192);
            this.btnWithoutBottle.Name = "btnWithoutBottle";
            this.btnWithoutBottle.Size = new System.Drawing.Size(141, 42);
            this.btnWithoutBottle.TabIndex = 8;
            this.btnWithoutBottle.Text = "ні";
            this.btnWithoutBottle.UseVisualStyleBackColor = true;
            this.btnWithoutBottle.Visible = false;
            this.btnWithoutBottle.Click += new System.EventHandler(this.btnWithoutBottle_Click);
            // 
            // btnWithBottle
            // 
            this.btnWithBottle.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnWithBottle.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWithBottle.Location = new System.Drawing.Point(486, 192);
            this.btnWithBottle.Name = "btnWithBottle";
            this.btnWithBottle.Size = new System.Drawing.Size(141, 42);
            this.btnWithBottle.TabIndex = 9;
            this.btnWithBottle.Text = "так";
            this.btnWithBottle.UseVisualStyleBackColor = true;
            this.btnWithBottle.Visible = false;
            this.btnWithBottle.Click += new System.EventHandler(this.btnWithBottle_Click);
            // 
            // textBoxCountOfBottles
            // 
            this.textBoxCountOfBottles.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountOfBottles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountOfBottles.Font = new System.Drawing.Font("Impact", 26.25F);
            this.textBoxCountOfBottles.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxCountOfBottles.Location = new System.Drawing.Point(617, 126);
            this.textBoxCountOfBottles.MaxLength = 2;
            this.textBoxCountOfBottles.Name = "textBoxCountOfBottles";
            this.textBoxCountOfBottles.Size = new System.Drawing.Size(42, 50);
            this.textBoxCountOfBottles.TabIndex = 10;
            this.textBoxCountOfBottles.Visible = false;
            // 
            // labelCountOfBottles
            // 
            this.labelCountOfBottles.AutoSize = true;
            this.labelCountOfBottles.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfBottles.ForeColor = System.Drawing.Color.Black;
            this.labelCountOfBottles.Location = new System.Drawing.Point(230, 124);
            this.labelCountOfBottles.Name = "labelCountOfBottles";
            this.labelCountOfBottles.Size = new System.Drawing.Size(387, 40);
            this.labelCountOfBottles.TabIndex = 11;
            this.labelCountOfBottles.Text = "Кількість пляшок (2л):";
            this.labelCountOfBottles.Visible = false;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.SlateGray;
            this.btnBuy.Location = new System.Drawing.Point(404, 192);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(141, 42);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "купити";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Visible = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // labelCountOfLiters
            // 
            this.labelCountOfLiters.AutoSize = true;
            this.labelCountOfLiters.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountOfLiters.ForeColor = System.Drawing.Color.Black;
            this.labelCountOfLiters.Location = new System.Drawing.Point(311, 134);
            this.labelCountOfLiters.Name = "labelCountOfLiters";
            this.labelCountOfLiters.Size = new System.Drawing.Size(283, 40);
            this.labelCountOfLiters.TabIndex = 13;
            this.labelCountOfLiters.Text = "Кількість літрів:";
            this.labelCountOfLiters.Visible = false;
            // 
            // textBoxCountOfLiters
            // 
            this.textBoxCountOfLiters.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCountOfLiters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCountOfLiters.Font = new System.Drawing.Font("Impact", 26.25F);
            this.textBoxCountOfLiters.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxCountOfLiters.Location = new System.Drawing.Point(600, 126);
            this.textBoxCountOfLiters.MaxLength = 3;
            this.textBoxCountOfLiters.Name = "textBoxCountOfLiters";
            this.textBoxCountOfLiters.Size = new System.Drawing.Size(60, 50);
            this.textBoxCountOfLiters.TabIndex = 14;
            this.textBoxCountOfLiters.Visible = false;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.ForeColor = System.Drawing.Color.Black;
            this.labelSum.Location = new System.Drawing.Point(73, 256);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(113, 40);
            this.labelSum.TabIndex = 15;
            this.labelSum.Text = "Cума:";
            this.labelSum.Visible = false;
            // 
            // labelPayMehod
            // 
            this.labelPayMehod.AutoSize = true;
            this.labelPayMehod.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayMehod.ForeColor = System.Drawing.Color.Black;
            this.labelPayMehod.Location = new System.Drawing.Point(350, 141);
            this.labelPayMehod.Name = "labelPayMehod";
            this.labelPayMehod.Size = new System.Drawing.Size(244, 40);
            this.labelPayMehod.TabIndex = 16;
            this.labelPayMehod.Text = "Спосіб оплати";
            this.labelPayMehod.Visible = false;
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.Color.SlateGray;
            this.btnCash.Location = new System.Drawing.Point(259, 192);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(141, 42);
            this.btnCash.TabIndex = 17;
            this.btnCash.Text = "готівкою";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Visible = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnWithCard
            // 
            this.btnWithCard.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnWithCard.ForeColor = System.Drawing.Color.SlateGray;
            this.btnWithCard.Location = new System.Drawing.Point(486, 192);
            this.btnWithCard.Name = "btnWithCard";
            this.btnWithCard.Size = new System.Drawing.Size(141, 42);
            this.btnWithCard.TabIndex = 18;
            this.btnWithCard.Text = "карткою";
            this.btnWithCard.UseVisualStyleBackColor = true;
            this.btnWithCard.Visible = false;
            this.btnWithCard.Click += new System.EventHandler(this.btnWithCard_Click);
            // 
            // labelWaterInMachine
            // 
            this.labelWaterInMachine.AutoSize = true;
            this.labelWaterInMachine.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterInMachine.ForeColor = System.Drawing.Color.Black;
            this.labelWaterInMachine.Location = new System.Drawing.Point(72, 357);
            this.labelWaterInMachine.Name = "labelWaterInMachine";
            this.labelWaterInMachine.Size = new System.Drawing.Size(317, 40);
            this.labelWaterInMachine.TabIndex = 19;
            this.labelWaterInMachine.Text = "Кількість води (л):";
            // 
            // labelCacheAmount
            // 
            this.labelCacheAmount.AutoSize = true;
            this.labelCacheAmount.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCacheAmount.ForeColor = System.Drawing.Color.Black;
            this.labelCacheAmount.Location = new System.Drawing.Point(263, 138);
            this.labelCacheAmount.Name = "labelCacheAmount";
            this.labelCacheAmount.Size = new System.Drawing.Size(239, 40);
            this.labelCacheAmount.TabIndex = 20;
            this.labelCacheAmount.Text = "Сума готівки:";
            this.labelCacheAmount.Visible = false;
            // 
            // textBoxCashAmount
            // 
            this.textBoxCashAmount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCashAmount.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxCashAmount.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxCashAmount.Location = new System.Drawing.Point(508, 139);
            this.textBoxCashAmount.MaxLength = 6;
            this.textBoxCashAmount.Name = "textBoxCashAmount";
            this.textBoxCashAmount.Size = new System.Drawing.Size(141, 37);
            this.textBoxCashAmount.TabIndex = 21;
            this.textBoxCashAmount.Visible = false;
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.SlateGray;
            this.btnPay.Location = new System.Drawing.Point(417, 195);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 42);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "платити";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Visible = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBottlesToolStripMenuItem,
            this.getIncomeToolStripMenuItem,
            this.getAdressToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addBottlesToolStripMenuItem
            // 
            this.addBottlesToolStripMenuItem.Name = "addBottlesToolStripMenuItem";
            this.addBottlesToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addBottlesToolStripMenuItem.Text = "Add";
            this.addBottlesToolStripMenuItem.Click += new System.EventHandler(this.addBottlesToolStripMenuItem_Click);
            // 
            // getIncomeToolStripMenuItem
            // 
            this.getIncomeToolStripMenuItem.Name = "getIncomeToolStripMenuItem";
            this.getIncomeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.getIncomeToolStripMenuItem.Text = "Get Income";
            this.getIncomeToolStripMenuItem.Click += new System.EventHandler(this.getIncomeToolStripMenuItem_Click);
            // 
            // getAdressToolStripMenuItem
            // 
            this.getAdressToolStripMenuItem.Name = "getAdressToolStripMenuItem";
            this.getAdressToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.getAdressToolStripMenuItem.Text = "Get Adress";
            this.getAdressToolStripMenuItem.Click += new System.EventHandler(this.getAdressToolStripMenuItem_Click);
            // 
            // labelBottlesCount
            // 
            this.labelBottlesCount.AutoSize = true;
            this.labelBottlesCount.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottlesCount.ForeColor = System.Drawing.Color.Black;
            this.labelBottlesCount.Location = new System.Drawing.Point(73, 411);
            this.labelBottlesCount.Name = "labelBottlesCount";
            this.labelBottlesCount.Size = new System.Drawing.Size(316, 40);
            this.labelBottlesCount.TabIndex = 25;
            this.labelBottlesCount.Text = "Кількість пляшок:";
            // 
            // labelStillWaterPrice
            // 
            this.labelStillWaterPrice.AutoSize = true;
            this.labelStillWaterPrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStillWaterPrice.ForeColor = System.Drawing.Color.Black;
            this.labelStillWaterPrice.Location = new System.Drawing.Point(543, 305);
            this.labelStillWaterPrice.Name = "labelStillWaterPrice";
            this.labelStillWaterPrice.Size = new System.Drawing.Size(212, 40);
            this.labelStillWaterPrice.TabIndex = 26;
            this.labelStillWaterPrice.Text = "Негазована:";
            // 
            // labelSodaPrice
            // 
            this.labelSodaPrice.AutoSize = true;
            this.labelSodaPrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSodaPrice.ForeColor = System.Drawing.Color.Black;
            this.labelSodaPrice.Location = new System.Drawing.Point(543, 357);
            this.labelSodaPrice.Name = "labelSodaPrice";
            this.labelSodaPrice.Size = new System.Drawing.Size(172, 40);
            this.labelSodaPrice.TabIndex = 27;
            this.labelSodaPrice.Text = "Газована:";
            // 
            // labelBottlePrice
            // 
            this.labelBottlePrice.AutoSize = true;
            this.labelBottlePrice.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottlePrice.ForeColor = System.Drawing.Color.Black;
            this.labelBottlePrice.Location = new System.Drawing.Point(543, 411);
            this.labelBottlePrice.Name = "labelBottlePrice";
            this.labelBottlePrice.Size = new System.Drawing.Size(232, 40);
            this.labelBottlePrice.TabIndex = 28;
            this.labelBottlePrice.Text = "Пляшка (2л):";
            // 
            // labelPrices
            // 
            this.labelPrices.AutoSize = true;
            this.labelPrices.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrices.ForeColor = System.Drawing.Color.Black;
            this.labelPrices.Location = new System.Drawing.Point(604, 256);
            this.labelPrices.Name = "labelPrices";
            this.labelPrices.Size = new System.Drawing.Size(93, 40);
            this.labelPrices.TabIndex = 29;
            this.labelPrices.Text = "Ціни";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAddWater
            // 
            this.btnAddWater.Font = new System.Drawing.Font("Impact", 15.75F);
            this.btnAddWater.ForeColor = System.Drawing.Color.SlateGray;
            this.btnAddWater.Location = new System.Drawing.Point(387, 213);
            this.btnAddWater.Name = "btnAddWater";
            this.btnAddWater.Size = new System.Drawing.Size(115, 37);
            this.btnAddWater.TabIndex = 32;
            this.btnAddWater.Text = "додати";
            this.btnAddWater.UseVisualStyleBackColor = true;
            this.btnAddWater.Visible = false;
            this.btnAddWater.Click += new System.EventHandler(this.btnAddWater_Click);
            // 
            // textBoxWaterAdd
            // 
            this.textBoxWaterAdd.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxWaterAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWaterAdd.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxWaterAdd.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxWaterAdd.Location = new System.Drawing.Point(534, 129);
            this.textBoxWaterAdd.MaxLength = 3;
            this.textBoxWaterAdd.Name = "textBoxWaterAdd";
            this.textBoxWaterAdd.Size = new System.Drawing.Size(85, 37);
            this.textBoxWaterAdd.TabIndex = 31;
            this.textBoxWaterAdd.Text = "0";
            this.textBoxWaterAdd.Visible = false;
            this.textBoxWaterAdd.WordWrap = false;
            // 
            // labelWaterAdd
            // 
            this.labelWaterAdd.AutoSize = true;
            this.labelWaterAdd.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterAdd.ForeColor = System.Drawing.Color.Black;
            this.labelWaterAdd.Location = new System.Drawing.Point(311, 124);
            this.labelWaterAdd.Name = "labelWaterAdd";
            this.labelWaterAdd.Size = new System.Drawing.Size(222, 40);
            this.labelWaterAdd.TabIndex = 30;
            this.labelWaterAdd.Text = "Додати воду:";
            this.labelWaterAdd.Visible = false;
            this.labelWaterAdd.Click += new System.EventHandler(this.labelWaterAdd_Click);
            // 
            // textBoxBottleAdd
            // 
            this.textBoxBottleAdd.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBottleAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBottleAdd.Font = new System.Drawing.Font("Impact", 18.25F);
            this.textBoxBottleAdd.ForeColor = System.Drawing.Color.SlateGray;
            this.textBoxBottleAdd.Location = new System.Drawing.Point(534, 172);
            this.textBoxBottleAdd.MaxLength = 3;
            this.textBoxBottleAdd.Name = "textBoxBottleAdd";
            this.textBoxBottleAdd.Size = new System.Drawing.Size(85, 37);
            this.textBoxBottleAdd.TabIndex = 34;
            this.textBoxBottleAdd.Text = "0";
            this.textBoxBottleAdd.Visible = false;
            this.textBoxBottleAdd.WordWrap = false;
            // 
            // labelBottleAdd
            // 
            this.labelBottleAdd.AutoSize = true;
            this.labelBottleAdd.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold);
            this.labelBottleAdd.ForeColor = System.Drawing.Color.Black;
            this.labelBottleAdd.Location = new System.Drawing.Point(254, 170);
            this.labelBottleAdd.Name = "labelBottleAdd";
            this.labelBottleAdd.Size = new System.Drawing.Size(279, 40);
            this.labelBottleAdd.TabIndex = 33;
            this.labelBottleAdd.Text = "Додати пляшки:";
            this.labelBottleAdd.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 474);
            this.Controls.Add(this.textBoxBottleAdd);
            this.Controls.Add(this.labelBottleAdd);
            this.Controls.Add(this.btnAddWater);
            this.Controls.Add(this.textBoxWaterAdd);
            this.Controls.Add(this.labelWaterAdd);
            this.Controls.Add(this.labelPrices);
            this.Controls.Add(this.labelBottlePrice);
            this.Controls.Add(this.labelSodaPrice);
            this.Controls.Add(this.labelStillWaterPrice);
            this.Controls.Add(this.labelBottlesCount);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.textBoxCashAmount);
            this.Controls.Add(this.labelCacheAmount);
            this.Controls.Add(this.labelWaterInMachine);
            this.Controls.Add(this.btnWithCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.labelPayMehod);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textBoxCountOfLiters);
            this.Controls.Add(this.labelCountOfLiters);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.labelCountOfBottles);
            this.Controls.Add(this.textBoxCountOfBottles);
            this.Controls.Add(this.btnWithBottle);
            this.Controls.Add(this.btnWithoutBottle);
            this.Controls.Add(this.labelOwnBottle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWaterTypeSoda);
            this.Controls.Add(this.btnWaterTypeStill);
            this.Controls.Add(this.labelWaterType);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "WaterMachine";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWaterType;
        private System.Windows.Forms.Button btnWaterTypeStill;
        private System.Windows.Forms.Button btnWaterTypeSoda;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelOwnBottle;
        private System.Windows.Forms.Button btnWithoutBottle;
        private System.Windows.Forms.Button btnWithBottle;
        private System.Windows.Forms.TextBox textBoxCountOfBottles;
        private System.Windows.Forms.Label labelCountOfBottles;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label labelCountOfLiters;
        private System.Windows.Forms.TextBox textBoxCountOfLiters;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelPayMehod;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnWithCard;
        private System.Windows.Forms.Label labelWaterInMachine;
        private System.Windows.Forms.Label labelCacheAmount;
        private System.Windows.Forms.TextBox textBoxCashAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addBottlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getIncomeToolStripMenuItem;
        private System.Windows.Forms.Label labelBottlesCount;
        private System.Windows.Forms.Label labelStillWaterPrice;
        private System.Windows.Forms.Label labelSodaPrice;
        private System.Windows.Forms.Label labelBottlePrice;
        private System.Windows.Forms.Label labelPrices;
        private System.Windows.Forms.ToolStripMenuItem getAdressToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnAddWater;
        private System.Windows.Forms.TextBox textBoxWaterAdd;
        private System.Windows.Forms.Label labelWaterAdd;
        private System.Windows.Forms.TextBox textBoxBottleAdd;
        private System.Windows.Forms.Label labelBottleAdd;
    }
}

