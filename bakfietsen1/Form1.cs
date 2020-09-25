using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bakfietsen1
{

    public partial class Form1 : Form
    {
        int aantaldagen;
        decimal[] bikePrice = new decimal[5];
        int optionBike;
        readonly string errorTotalMsg = @" Optie not a number";
        readonly string errorOptionOutOfRange = @"Option needs to be between 1 and 4";
        readonly string errorOngeldigWaarde = @"Ongeldig waarde";
        readonly string BabyStoeltje = @"BabyStoeltje";
        readonly string RegenDak = @"RegenDak";
        List<Accessiores> checkBoxItems = new List<Accessiores>();


        public Form1()
        {
            InitializeComponent();
            //Bike types prijs
            bikePrice[0] = 0;
            bikePrice[1] = 10;
            bikePrice[2] = 20;
            bikePrice[3] = 30;
            bikePrice[4] = 40;
            
        }

        public void getString(decimal prijs)
        {
            TotaleKosten.Text = string.Format("Totale Kosten {0}", prijs);

        }

        public void showHuidigeHuur(decimal prijs)
        {
            TotaleKosten.Text = string.Format("Huidige huurkosten {0}", prijs);
        }
       
        public decimal calculate_Bikeprice()
        {
            decimal result = 0;

            aantaldagen = Convert.ToInt32(Aantaldagen.Value);
            var isValid = Int32.TryParse(OptieBikeTxt.Text, out optionBike); // fix datatype conversion here

            result = aantaldagen * bikePrice[optionBike];

            //foreach (var item in accesoires)
            //{
            //    result = result + item;
            //}

            foreach (var item in checkBoxItems) 
            {
                result = result + item.Bedrag;
            }


            return result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateOption(OptieBikeTxt.Text))
            {
                getString(calculate_Bikeprice());
            }
            else
            {
                TotaleKosten.Text = errorOngeldigWaarde;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void OptieBikeTxt_TextChanged(object sender, EventArgs e)
        {
            //get value
            if (ValidateOption(OptieBikeTxt.Text))
            {
                showHuidigeHuur(calculate_Bikeprice());
            }
            else
            {
                TotaleKosten.Text = errorOngeldigWaarde;
            }

        }

        private bool ValidateOption(string value)
        {
            int option;
            //var lol = Int32.TryParse(OptieBikeTxt.Text, out  option);

            try
            {
                option = Convert.ToInt32(OptieBikeTxt.Text);

                if ((option > 4) || option < 1)
                {
                    TotaleKosten.Text = errorOptionOutOfRange;
                    return false;
                }


            }
            catch
            {
                TotaleKosten.Text = errorTotalMsg;
                return false;
            }
            return true;
        }

        private void regendakBx_CheckedChanged(object sender, EventArgs e)
        {


            if (regendakBx.Checked)
            {
                AddToAccessoryList(RegenDak,12);
            }
            else
            {
                RemoveFromAccessoryList(RegenDak);
            }

        }

        private void babystoeltje_Bx_CheckedChanged(object sender, EventArgs e)
        {
            if (babystoeltje_Bx.Checked)
            {
                AddToAccessoryList(BabyStoeltje,20);
            }
            else
            {
                RemoveFromAccessoryList(BabyStoeltje);
            }
        }

        private void Smartphone_Bx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KaartHouder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void helm_Bx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddToAccessoryList(string name,decimal bedrag) 
        {
            var accessoire = new Accessiores
            {
                Name = name,
                Bedrag = bedrag

            };
            checkBoxItems.Add(accessoire);
        }

        private void RemoveFromAccessoryList(string name) 
        {
            checkBoxItems.RemoveAll((x) => x.Name == name);
        }

        private void Aantaldagen_ValueChanged(object sender, EventArgs e)
        {
            if (ValidateOption(OptieBikeTxt.Text))
            {
                showHuidigeHuur(calculate_Bikeprice());
            }
            else
            {
                TotaleKosten.Text = errorOngeldigWaarde;
            }
        }
    }
}






