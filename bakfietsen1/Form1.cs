using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace bakfietsen1
{


    public partial class Form1 : Form
    {
        double optie;
        double result1;
        double aantaldagen;
        double[] bikePrice = new double[5];
        double[] accesoires = new double[6];
        int optionBike;
        

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

       public void getString()
        {
            List<String> words = new List<String>();

            words.Add("Totale");
            words.Add("Kosten");
            string s;
            s = words.ElementAt(0) + " " + words[1];
            TotaleKosten.Text = Convert.ToString(s);
        }

        void accesoires_price()
        {
           
            if (regendakBx.Checked == true)
            {
                accesoires[1] = 12;  
            }
            else if (regendakBx.Checked == false)
            {
                accesoires[1] = 0;
            }

            if (babystoeltje_Bx.Checked == true)
            {
                accesoires[2] = 20;
            }
            else if (babystoeltje_Bx.Checked == false)
            {
                accesoires[2] = 0;
            }

            if (Smartphone_Bx.Checked == true)
            {
                accesoires[3] = 8;
            }
            else if (Smartphone_Bx.Checked == false)
            {
                accesoires[3] = 0;
            }

            if (KaartHouder.Checked == true)
            {
                accesoires[4] = 5;
            }
            else if (KaartHouder.Checked == false)
            {
                accesoires[4] = 0;
            }
            if (helm_Bx.Checked == true)
            {
                accesoires[5] = 10;
            }
            else if (helm_Bx.Checked == false)
            {
                accesoires[5] = 0;
            }
        }

        public void calculate_Bikeprice()
        {
            
            aantaldagen = Convert.ToDouble(Aantaldagen.Value);
            int.TryParse(OptieBikeTxt.Text, out optionBike);
            optie = optionBike; //Convert.ToDouble(OptieBikeTxt.Text);

            accesoires_price();  // methode aanroepen
            bool loopBreak = true;
            while (loopBreak == true)
            {
                Total.Text = "Kies jouw optie type bike-> 1 t/m 4";

                switch (optie)
                {

                    case 1:
                        result1 = (aantaldagen * bikePrice[1]) + accesoires[1] + accesoires[2] + accesoires[3] + accesoires[4] + accesoires[5];
                        Total.Text = ("€" + Convert.ToString(result1));
                        getString();
                        break;
                    case 2:
                        result1 = (aantaldagen * bikePrice[2]) + accesoires[1] + accesoires[2] + accesoires[3] + accesoires[4] + accesoires[5];
                        Total.Text = ("€" + Convert.ToString(result1));
                        getString();
                        break;
                    case 3:
                        result1 = (aantaldagen * bikePrice[3]) + accesoires[1] + accesoires[2] + accesoires[3] + accesoires[4] + accesoires[5];
                        Total.Text = ("€" + Convert.ToString(result1));
                        getString();
                        break;
                    case 4:
                        result1 = (aantaldagen * bikePrice[4]) + accesoires[1] + accesoires[2] + accesoires[3] + accesoires[4] + accesoires[5];
                        Total.Text = ("€" + Convert.ToString(result1));
                        getString();
                        break;

                    default:
                        loopBreak = false;
                        break;
                }
                break;
            }

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate_Bikeprice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


      
    
  

