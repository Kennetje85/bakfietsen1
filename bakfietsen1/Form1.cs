using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace bakfietsen1
{
    enum option
    {
        None = 0,
        ClassicShort = 10,
        ClassicShortEbike = 20,
        ClassicLargeBike = 30,
        ClassicLargeEbike = 40
    }

    public partial class Form1 : Form
    {
        double optie;
        double result1;
        int aantaldagen;
        decimal[] bikePrice = new decimal[5];
        decimal[] accesoires = new decimal[6];
        int optionBike;
        readonly string errorTotalMsg = @" Optie not a number";
        readonly string errorOptionOutOfRange = @"Option needs to be between 1 and 4";
        readonly string errorOngeldigWaarde = @"Ongeldig waarde";
        option test = option.None;
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
            test = option.None;
        }

        public void getString(decimal prijs)
        {
            TotaleKosten.Text = string.Format("Totale Kosten {0}", prijs);

        }

        public void showHuidigeHuur(decimal prijs)
        {
            TotaleKosten.Text = string.Format("Huidige huurkosten {0}", prijs);
        }

        void accesoires_price()
        {

            if (regendakBx.Checked == true)
            {
                accesoires[1] = 12;
            }
            else
            {
                accesoires[1] = 0;
            }

            if (babystoeltje_Bx.Checked == true)
            {
                accesoires[2] = 20;
            }
            else
            {
                accesoires[2] = 0;
            }

            if (Smartphone_Bx.Checked == true)
            {
                accesoires[3] = 8;
            }
            else
            {
                accesoires[3] = 0;
            }

            if (KaartHouder.Checked == true)
            {
                accesoires[4] = 5;
            }
            else
            {
                accesoires[4] = 0;
            }
            if (helm_Bx.Checked == true)
            {
                accesoires[5] = 10;
            }
            else
            {
                accesoires[5] = 0;
            }
        }

        public decimal calculate_Bikeprice()
        {
            decimal result = 0;

            aantaldagen = Convert.ToInt32(Aantaldagen.Value);
            var isValid = Int32.TryParse(OptieBikeTxt.Text, out optionBike); // fix datatype conversion here
            optie = optionBike; //Convert.ToDouble(OptieBikeTxt.Text);

            accesoires_price();  // methode aanroepen
                                 //bool loopBreak = true;


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
                //Total.Text = errorTotalMsg;
                return false;
            }
            return true;
        }

        private void regendakBx_CheckedChanged(object sender, EventArgs e)
        {

            regendakBx.Checked?AddToAccessoryList("Regendak"):RemoveFromAccessoryList("Regendak");
            //if (regendakBx.Checked)
            //{
            //    var accessoire = new Accessiores
            //    {
            //        Name = "Regendak",
            //        Bedrag = 12

            //    };
            //    checkBoxItems.Add(accessoire);
            //}
            //else {
            //    checkBoxItems.RemoveAll((x) => x.Name == "Regendak");
            //}


        }

        private void babystoeltje_Bx_CheckedChanged(object sender, EventArgs e)
        {
            if (babystoeltje_Bx.Checked)
            {
                var accessoire = new Accessiores
                {
                    Name = "BabyStoeltje",
                    Bedrag = 20

                };
                checkBoxItems.Add(accessoire);
            }
            else
            {
                checkBoxItems.RemoveAll((x) => x.Name == "BabyStoeltje");
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

        private void AddToAccessoryList(string name) 
        {
            var accessoire = new Accessiores
            {
                Name = name,
                Bedrag = 20

            };
            checkBoxItems.Add(accessoire);
        }

        private void RemoveFromAccessoryList(string name) 
        {
            checkBoxItems.RemoveAll((x) => x.Name == name);
        }
    }
}






