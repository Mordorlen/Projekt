using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RouletteGame
{
    public partial class Ruletka : Form
    {
        private int balance = 1000;
        private Random random = new Random();
        private readonly int[] redNumbers = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };


        private List<int> lastResults = new List<int>();
        private int winsCount = 0;
        private int lossesCount = 0;

        public Ruletka()
        {
            InitializeComponent();
            InitializeNewComponents();
            Typbetu.SelectedIndex = 0;
            UpdateBalanceDisplay();
            UpdateStatsDisplay();

        }

        private void InitializeNewComponents()
        {
            Poletła.Items.AddRange(new[] { "Klasyczny", "Ciemny", "Neonowy" });
            Poletła.SelectedIndex = 0;
            historia.Font = new Font("Consolas", 10);



        }

        private void UpdateBalanceDisplay()
        {
            PoleSalda.Text = $"Saldo: {balance}$";
            Kwota.Maximum = balance;
            if (balance <= 0)
            {
                zakręć.Enabled = false;
                MessageBox.Show("Koniec gry! Twoje saldo wynosi 0$.");
            }
        }

        private string GetColor(int number)
        {
            if (number == 0) return "Zielony";
            return redNumbers.Contains(number) ? "Czerwony" : "Czarny";
        }

        private bool CheckWin(string betType, string betValue, int resultNumber, string resultColor)
        {
            if (resultNumber == 0)
                return betType == "Konkretny numer" && betValue == "0";

            switch (betType)
            {
                case "Kolor":
                    return betValue == resultColor;
                case "Parzyste/Nieparzyste":
                    bool isEven = resultNumber % 2 == 0;
                    return (isEven && betValue == "Parzyste") || (!isEven && betValue == "Nieparzyste");
                case "Konkretny numer":
                    return betValue == resultNumber.ToString();
                case "Tuziny":
                    return CheckDozenBet(betValue, resultNumber);
                default:
                    return false;
            }
        }

        private bool CheckDozenBet(string betValue, int resultNumber)
        {
            if (resultNumber == 0) return false;
            switch (betValue)
            {
                case "1-12": return resultNumber >= 1 && resultNumber <= 12;
                case "13-24": return resultNumber >= 13 && resultNumber <= 24;
                case "25-36": return resultNumber >= 25 && resultNumber <= 36;
                default: return false;
            }
        }

        private int CalculatePayout(bool isWin, string betType, int betAmount)
        {
            if (!isWin) return -betAmount;

            switch (betType)
            {
                case "Kolor":
                case "Parzyste/Nieparzyste":
                    return betAmount;
                case "Tuziny":
                    return betAmount * 2;
                case "Konkretny numer":
                    return betAmount * 35;
                default:
                    return 0;
            }
        }



        private void spinButton_Click(object sender, EventArgs e)
        {


            int betAmount = (int)Kwota.Value;
            string betType = Typbetu.Text;
            string betValue = "";
            int resultNumber = random.Next(0, 37);
            string resultColor = GetColor(resultNumber);

            switch (betType)
            {
                case "Kolor":
                    if (czerwony.Checked) betValue = "Czerwony";
                    else if (czarny.Checked) betValue = "Czarny";
                    else if (zielony.Checked) betValue = "Zielony";
                    else
                    {
                        MessageBox.Show("Wybierz kolor");
                        return;
                    }
                    break;
                case "Parzyste/Nieparzyste":
                    if (parzyste.Checked) betValue = "Parzyste";
                    else if (nieparzyate.Checked) betValue = "Nieparzyste";
                    else
                    {
                        MessageBox.Show("Wybierz parzyste lub nieparzyste");
                        return;
                    }
                    break;
                case "Konkretny numer":
                    betValue = numeryn.Value.ToString();
                    break;
                case "Tuziny":
                    if (pierwszytuzin.Checked) betValue = "1-12";
                    else if (drugituzin.Checked) betValue = "13-24";
                    else if (trzecituzin.Checked) betValue = "25-36";
                    else
                    {
                        MessageBox.Show("Wybierz tuzin!");
                        return;
                    }
                    break;
            }

            bool isWin = CheckWin(betType, betValue, resultNumber, resultColor);
            int payout = CalculatePayout(isWin, betType, betAmount);

            balance += payout;
            UpdateBalanceDisplay();


            if (isWin) winsCount++; else lossesCount++;
            lastResults.Insert(0, resultNumber);
            if (lastResults.Count > 10) lastResults.RemoveAt(10);


            wynik.Text = $"Wynik: {resultNumber} {resultColor}";
            wynik.ForeColor = resultColor == "Czerwony" ? Color.Red :
                                  resultColor == "Zielony" ? Color.Green : Color.Black;

            Rezultat.Text = isWin ? $"Wygrałeś {payout}$!" : "Przegrałeś zakład.";
            UpdateStatsDisplay();
        }


        private void UpdateStatsDisplay()
        {
            Tabelastatystyk.Text = $"Wygrane: {winsCount} | Przegrane: {lossesCount}";
            historia.Items.Clear();
            foreach (var result in lastResults)
            {
                historia.Items.Add($"{result} - {GetColor(result)}");
            }
        }

        private void ApplyTheme(string theme)
        {
            switch (theme)
            {
                case "Ciemny":
                    BackColor = Color.FromArgb(40, 40, 40);
                    ForeColor = Color.White;
                    break;
                case "Neonowy":
                    BackColor = Color.Black;
                    ForeColor = Color.Lime;
                    break;
                default:
                    BackColor = SystemColors.Control;
                    ForeColor = SystemColors.ControlText;
                    break;
            }
            UpdateControlColors(this.Controls);
        }

        private void UpdateControlColors(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.BackColor = BackColor;
                control.ForeColor = ForeColor;
                if (control.HasChildren) UpdateControlColors(control.Controls);
            }
        }


        private void themeComboBox_SelectedIndexChanged(object sender, EventArgs e) => ApplyTheme(Poletła.Text);
        private void betTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kolor.Visible = Typbetu.Text == "Kolor";
            przystenieparzyste.Visible = Typbetu.Text == "Parzyste/Nieparzyste";
            betowanieliczb.Visible = Typbetu.Text == "Konkretny numer";
            tuziny.Visible = Typbetu.Text == "Tuziny";
        }
    }
}