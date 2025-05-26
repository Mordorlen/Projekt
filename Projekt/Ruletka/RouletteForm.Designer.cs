namespace RouletteGame
{
    partial class RouletteForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.PoleSalda = new System.Windows.Forms.Label();
            this.Kwota = new System.Windows.Forms.NumericUpDown();
            this.Typbetu = new System.Windows.Forms.ComboBox();
            this.kolor = new System.Windows.Forms.Panel();
            this.zielony = new System.Windows.Forms.RadioButton();
            this.czarny = new System.Windows.Forms.RadioButton();
            this.czerwony = new System.Windows.Forms.RadioButton();
            this.przystenieparzyste = new System.Windows.Forms.Panel();
            this.nieparzyate = new System.Windows.Forms.RadioButton();
            this.parzyste = new System.Windows.Forms.RadioButton();
            this.betowanieliczb = new System.Windows.Forms.Panel();
            this.numeryn = new System.Windows.Forms.NumericUpDown();
            this.zakręć = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.Rezultat = new System.Windows.Forms.Label();
            this.Poletła = new System.Windows.Forms.ComboBox();
            this.historia = new System.Windows.Forms.ListBox();
            this.Tabelastatystyk = new System.Windows.Forms.Label();
            this.tuziny = new System.Windows.Forms.Panel();
            this.trzecituzin = new System.Windows.Forms.RadioButton();
            this.drugituzin = new System.Windows.Forms.RadioButton();
            this.pierwszytuzin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Kwota)).BeginInit();
            this.kolor.SuspendLayout();
            this.przystenieparzyste.SuspendLayout();
            this.betowanieliczb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeryn)).BeginInit();
            this.tuziny.SuspendLayout();
            this.SuspendLayout();
            // 
            // PoleSalda
            // 
            this.PoleSalda.AutoSize = true;
            this.PoleSalda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PoleSalda.Location = new System.Drawing.Point(20, 20);
            this.PoleSalda.Name = "PoleSalda";
            this.PoleSalda.Size = new System.Drawing.Size(103, 20);
            this.PoleSalda.TabIndex = 0;
            this.PoleSalda.Text = "Saldo: 1000$";
            // 
            // Kwota
            // 
            this.Kwota.Location = new System.Drawing.Point(24, 60);
            this.Kwota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Kwota.Name = "Kwota";
            this.Kwota.Size = new System.Drawing.Size(120, 20);
            this.Kwota.TabIndex = 1;
            this.Kwota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Typbetu
            // 
            this.Typbetu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Typbetu.FormattingEnabled = true;
            this.Typbetu.Items.AddRange(new object[] {
            "Tuziny",
            "Kolor",
            "Parzyste/Nieparzyste",
            "Konkretny numer"});
            this.Typbetu.Location = new System.Drawing.Point(24, 100);
            this.Typbetu.Name = "Typbetu";
            this.Typbetu.Size = new System.Drawing.Size(120, 21);
            this.Typbetu.TabIndex = 2;
            this.Typbetu.SelectedIndexChanged += new System.EventHandler(this.betTypeComboBox_SelectedIndexChanged);
            // 
            // kolor
            // 
            this.kolor.Controls.Add(this.zielony);
            this.kolor.Controls.Add(this.czarny);
            this.kolor.Controls.Add(this.czerwony);
            this.kolor.Location = new System.Drawing.Point(24, 140);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(260, 50);
            this.kolor.TabIndex = 9;
            // 
            // zielony
            // 
            this.zielony.AutoSize = true;
            this.zielony.Location = new System.Drawing.Point(161, 10);
            this.zielony.Name = "zielony";
            this.zielony.Size = new System.Drawing.Size(59, 17);
            this.zielony.TabIndex = 2;
            this.zielony.Text = "Zielony";
            this.zielony.UseVisualStyleBackColor = true;
            // 
            // czarny
            // 
            this.czarny.AutoSize = true;
            this.czarny.Location = new System.Drawing.Point(90, 10);
            this.czarny.Name = "czarny";
            this.czarny.Size = new System.Drawing.Size(57, 17);
            this.czarny.TabIndex = 1;
            this.czarny.Text = "Czarny";
            this.czarny.UseVisualStyleBackColor = true;
            // 
            // czerwony
            // 
            this.czerwony.AutoSize = true;
            this.czerwony.Location = new System.Drawing.Point(10, 10);
            this.czerwony.Name = "czerwony";
            this.czerwony.Size = new System.Drawing.Size(71, 17);
            this.czerwony.TabIndex = 0;
            this.czerwony.Text = "Czerwony";
            this.czerwony.UseVisualStyleBackColor = true;
            // 
            // przystenieparzyste
            // 
            this.przystenieparzyste.Controls.Add(this.nieparzyate);
            this.przystenieparzyste.Controls.Add(this.parzyste);
            this.przystenieparzyste.Location = new System.Drawing.Point(24, 140);
            this.przystenieparzyste.Name = "przystenieparzyste";
            this.przystenieparzyste.Size = new System.Drawing.Size(200, 50);
            this.przystenieparzyste.TabIndex = 15;
            this.przystenieparzyste.Visible = false;
            // 
            // nieparzyate
            // 
            this.nieparzyate.AutoSize = true;
            this.nieparzyate.Location = new System.Drawing.Point(75, 10);
            this.nieparzyate.Name = "nieparzyate";
            this.nieparzyate.Size = new System.Drawing.Size(80, 17);
            this.nieparzyate.TabIndex = 1;
            this.nieparzyate.Text = "Nieparzyste";
            this.nieparzyate.UseVisualStyleBackColor = true;
            // 
            // parzyste
            // 
            this.parzyste.AutoSize = true;
            this.parzyste.Location = new System.Drawing.Point(10, 10);
            this.parzyste.Name = "parzyste";
            this.parzyste.Size = new System.Drawing.Size(65, 17);
            this.parzyste.TabIndex = 0;
            this.parzyste.Text = "Parzyste";
            this.parzyste.UseVisualStyleBackColor = true;
            // 
            // betowanieliczb
            // 
            this.betowanieliczb.Controls.Add(this.numeryn);
            this.betowanieliczb.Location = new System.Drawing.Point(24, 140);
            this.betowanieliczb.Name = "betowanieliczb";
            this.betowanieliczb.Size = new System.Drawing.Size(200, 50);
            this.betowanieliczb.TabIndex = 5;
            this.betowanieliczb.Visible = false;
            // 
            // numeryn
            // 
            this.numeryn.Location = new System.Drawing.Point(0, 0);
            this.numeryn.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numeryn.Name = "numeryn";
            this.numeryn.Size = new System.Drawing.Size(120, 20);
            this.numeryn.TabIndex = 0;
            // 
            // zakręć
            // 
            this.zakręć.Location = new System.Drawing.Point(24, 243);
            this.zakręć.Name = "zakręć";
            this.zakręć.Size = new System.Drawing.Size(100, 30);
            this.zakręć.TabIndex = 6;
            this.zakręć.Text = "Zakręć";
            this.zakręć.UseVisualStyleBackColor = true;
            this.zakręć.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(24, 286);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(59, 20);
            this.wynik.TabIndex = 7;
            this.wynik.Text = "Wynik: ";
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSize = true;
            this.Rezultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rezultat.Location = new System.Drawing.Point(24, 311);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(0, 20);
            this.Rezultat.TabIndex = 8;
            // 
            // Poletła
            // 
            this.Poletła.FormattingEnabled = true;
            this.Poletła.Location = new System.Drawing.Point(322, 60);
            this.Poletła.Name = "Poletła";
            this.Poletła.Size = new System.Drawing.Size(130, 21);
            this.Poletła.TabIndex = 10;
            this.Poletła.SelectedIndexChanged += new System.EventHandler(this.themeComboBox_SelectedIndexChanged);
            // 
            // historia
            // 
            this.historia.FormattingEnabled = true;
            this.historia.Location = new System.Drawing.Point(322, 150);
            this.historia.Name = "historia";
            this.historia.Size = new System.Drawing.Size(200, 147);
            this.historia.TabIndex = 13;
            // 
            // Tabelastatystyk
            // 
            this.Tabelastatystyk.AutoSize = true;
            this.Tabelastatystyk.Location = new System.Drawing.Point(322, 120);
            this.Tabelastatystyk.Name = "Tabelastatystyk";
            this.Tabelastatystyk.Size = new System.Drawing.Size(130, 13);
            this.Tabelastatystyk.TabIndex = 14;
            this.Tabelastatystyk.Text = "Wygrane: 0 | Przegrane: 0";
            // 
            // tuziny
            // 
            this.tuziny.Controls.Add(this.trzecituzin);
            this.tuziny.Controls.Add(this.drugituzin);
            this.tuziny.Controls.Add(this.pierwszytuzin);
            this.tuziny.Location = new System.Drawing.Point(24, 127);
            this.tuziny.Name = "tuziny";
            this.tuziny.Size = new System.Drawing.Size(200, 98);
            this.tuziny.TabIndex = 9;
            this.tuziny.Visible = false;
            // 
            // trzecituzin
            // 
            this.trzecituzin.AutoSize = true;
            this.trzecituzin.Location = new System.Drawing.Point(10, 70);
            this.trzecituzin.Name = "trzecituzin";
            this.trzecituzin.Size = new System.Drawing.Size(52, 17);
            this.trzecituzin.TabIndex = 2;
            this.trzecituzin.TabStop = true;
            this.trzecituzin.Text = "25-36";
            this.trzecituzin.UseVisualStyleBackColor = true;
            // 
            // drugituzin
            // 
            this.drugituzin.AutoSize = true;
            this.drugituzin.Location = new System.Drawing.Point(10, 40);
            this.drugituzin.Name = "drugituzin";
            this.drugituzin.Size = new System.Drawing.Size(52, 17);
            this.drugituzin.TabIndex = 1;
            this.drugituzin.TabStop = true;
            this.drugituzin.Text = "13-24";
            this.drugituzin.UseVisualStyleBackColor = true;
            // 
            // pierwszytuzin
            // 
            this.pierwszytuzin.AutoSize = true;
            this.pierwszytuzin.Location = new System.Drawing.Point(10, 10);
            this.pierwszytuzin.Name = "pierwszytuzin";
            this.pierwszytuzin.Size = new System.Drawing.Size(46, 17);
            this.pierwszytuzin.TabIndex = 0;
            this.pierwszytuzin.TabStop = true;
            this.pierwszytuzin.Text = "1-12";
            this.pierwszytuzin.UseVisualStyleBackColor = true;
            // 
            // RouletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.przystenieparzyste);
            this.Controls.Add(this.tuziny);
            this.Controls.Add(this.Tabelastatystyk);
            this.Controls.Add(this.betowanieliczb);
            this.Controls.Add(this.historia);
            this.Controls.Add(this.Poletła);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.zakręć);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.Typbetu);
            this.Controls.Add(this.Kwota);
            this.Controls.Add(this.PoleSalda);
            this.Name = "RouletteForm";
            this.Text = "Ruletka";
            ((System.ComponentModel.ISupportInitialize)(this.Kwota)).EndInit();
            this.kolor.ResumeLayout(false);
            this.kolor.PerformLayout();
            this.przystenieparzyste.ResumeLayout(false);
            this.przystenieparzyste.PerformLayout();
            this.betowanieliczb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeryn)).EndInit();
            this.tuziny.ResumeLayout(false);
            this.tuziny.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PoleSalda;
        private System.Windows.Forms.NumericUpDown Kwota;
        private System.Windows.Forms.ComboBox Typbetu;
        private System.Windows.Forms.Panel kolor;
        private System.Windows.Forms.RadioButton zielony;
        private System.Windows.Forms.RadioButton czarny;
        private System.Windows.Forms.RadioButton czerwony;
        private System.Windows.Forms.Panel przystenieparzyste;
        private System.Windows.Forms.RadioButton nieparzyate;
        private System.Windows.Forms.RadioButton parzyste;
        private System.Windows.Forms.Panel betowanieliczb;
        private System.Windows.Forms.NumericUpDown numeryn;
        private System.Windows.Forms.Button zakręć;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Label Rezultat;
        private System.Windows.Forms.ComboBox Poletła;
        private System.Windows.Forms.ListBox historia;
        private System.Windows.Forms.Label Tabelastatystyk;
        private System.Windows.Forms.Panel tuziny;
        private System.Windows.Forms.RadioButton trzecituzin;
        private System.Windows.Forms.RadioButton drugituzin;
        private System.Windows.Forms.RadioButton pierwszytuzin;
    }
}