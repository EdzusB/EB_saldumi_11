using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EB_saldumi_11_G
{
    public partial class Form1 : Form
    {
        double sk1 = 0;     //Definējam double tipa mainīgo
        double sk2 = 0;     //Definējam double tipa mainīgo
        double sk3 = 0;     //Definējam double tipa mainīgo
        double sk4 = 0;     //Definējam double tipa mainīgo
        double sk5 = 0;     //Definējam double tipa mainīgo
        double sk6 = 0;     //Definējam double tipa mainīgo
        double sk7 = 0;     //Definējam double tipa mainīgo
        double kg0 = 0;     //Definējam double tipa mainīgo
        double kg1 = 0;     //Definējam double tipa mainīgo
        double kg2 = 0;     //Definējam double tipa mainīgo
        double kg3 = 0;     //Definējam double tipa mainīgo
        double kg4 = 0;     //Definējam double tipa mainīgo
        double kg5 = 0;     //Definējam double tipa mainīgo
        double atlikums = 0;     //Definējam double tipa mainīgo
        double atlaide = 1;     //Definējam double tipa mainīgo
        double gala_atlaide = 0;     //Definējam double tipa mainīgo
        double summa = 0;     //Definējam double tipa mainīgo
        double gala_cena = 0;     //Definējam double tipa mainīgo
        double rez0 = 0;     //Definējam double tipa mainīgo
        double rez1 = 0;     //Definējam double tipa mainīgo
        double rez2 = 0;     //Definējam double tipa mainīgo
        double rez3 = 0;     //Definējam double tipa mainīgo
        double rez4 = 0;     //Definējam double tipa mainīgo
        double rez5 = 0;     //Definējam double tipa mainīgo

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aprekins_Click(object sender, EventArgs e)
        {
            if (text0.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                kg0 = 0;        //Piešķiram vērtību nulle
                izmaksas1.Text = 0.ToString();      //Pārvēršam par string tipa mainīgo
            }           
            else
            {
                kg0 = Convert.ToDouble(text0.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
                if (kg0<0)      //Pārbaudam vai Ievadītais daudzums nav mazāks par nulli
                {
                MessageBox.Show("Jūs mums pārdosiet konfektes?");       //Ja ievadītais dadzums mazāks par nulli izvada paziņojumu
               }              
            }            
            rez0 = Izmaksas0(kg0, sk2);     //Izsauc funkciju
            izmaksas1.Text = rez0.ToString();       //Rezultātu pārvērš par string tipa mainīgo n izvada teksta laukā

            if (text1.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                kg1 = 0;        //Piešķiram vērtību nulle
                izmaksas2.Text = 0.ToString();      //Pārvēršam par string tipa mainīgo
            }
            else
            {
                kg1 = Convert.ToDouble(text1.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
                if (kg1 < 0)//Pārbaudam vai Ievadītais daudzums nav mazāks par nulli
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");       //Ja ievadītais dadzums mazāks par nulli izvada paziņojumu
                }
            }
            rez1 = Izmaksas1(kg1, sk3);     //Izsauc funkciju
            izmaksas2.Text = rez1.ToString();       //Rezultātu pārvērš par string tipa mainīgo n izvada teksta laukā

            if (text2.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                kg2 = 0;        //Piešķiram vērtību nulle
                izmaksas3.Text = 0.ToString();      //Pārvēršam par string tipa mainīgo
            }
            else
            {
                kg2 = Convert.ToDouble(text2.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
                if (kg2 < 0)//Pārbaudam vai Ievadītais daudzums nav mazāks par nulli
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");       //Ja ievadītais dadzums mazāks par nulli izvada paziņojumu
                }

            }
            rez2 = Izmaksas2(kg2, sk4);     //Izsauc funkciju
            izmaksas3.Text = rez2.ToString();       //Rezultātu pārvērš par string tipa mainīgo n izvada teksta laukā


            if (text3.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                kg3 = 0;        //Piešķiram vērtību nulle
                izmaksas4.Text = 0.ToString();      //Pārvēršam par string tipa mainīgo
            }
            else
            {
                kg3 = Convert.ToDouble(text3.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
                if (kg3 < 0)//Pārbaudam vai Ievadītais daudzums nav mazāks par nulli
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");       //Ja ievadītais dadzums mazāks par nulli izvada paziņojumu
                }

            }
            rez3 = Izmaksas3(kg3, sk5);     //Izsauc funkciju
            izmaksas4.Text = rez3.ToString();       //Rezultātu pārvērš par string tipa mainīgo n izvada teksta laukā


            if (text4.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                kg4 = 0;        //Piešķiram vērtību nulle
                izmaksas5.Text = 0.ToString();      //Pārvēršam par string tipa mainīgo
            }
            else
            {
                kg4 = Convert.ToDouble(text4.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
                if (kg4 < 0)//Pārbaudam vai Ievadītais daudzums nav mazāks par nulli
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");       //Ja ievadītais dadzums mazāks par nulli izvada paziņojumu
                }

            }
            rez4 = Izmaksas4(kg4, sk6);     //Izsauc funkciju
            izmaksas5.Text = rez4.ToString();       //Rezultātu pārvērš par string tipa mainīgo n izvada teksta laukā


            if (text6.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                kg5 = 0;        //Piešķiram vērtību nulle
                izmaksas6.Text = 0.ToString();      //Pārvēršam par string tipa mainīgo
            }
            else
            {
                kg5 = Convert.ToDouble(text6.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
                if (kg5 < 0)//Pārbaudam vai Ievadītais daudzums nav mazāks par nulli
                {
                    MessageBox.Show("Jūs mums pārdosiet konfektes?");       //Ja ievadītais dadzums mazāks par nulli izvada paziņojumu
                }

            }
            rez5 = Izmaksas5(kg5, sk7);     //Izsauc funkciju
            izmaksas6.Text = rez5.ToString();       //Rezultātu pārvērš par string tipa mainīgo n izvada teksta laukā


            if (checkatlaide.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                atlaide = 0.13;     //Piešķir vērtību
                gala_atlaide = summa * atlaide;     //Aprēķina gala  atlaidi
                atlaidesbox.Text = gala_atlaide.ToString();     //Pārvērš par string tipa mainīgo un izvada teksta laukā
            }

            if(daudzums.Text == "")       //Pārbaudam vai lauks nav tukšs
            {
                MessageBox.Show("Lūdzu aizpildiet pieejamā naudas daudzuma lauku!");        //Izvada paziņojumu
            }
            else
            {
                 sk1 = Convert.ToDouble(daudzums.Text);       //Ja lauks aizpildīts, ievadīto daudzumu pārvēršam par string tipa mainīgo
            }
            
            summa = rez0 + rez1 + rez2 + rez3 + rez4 + rez5;        //Aprēķina pirkuma izmaksas
            gala_atlaide = sk1 * atlaide;       //Aprēķina gala atlaidi
            gala_cena = summa - gala_atlaide;       //Aprēķina pirkuma izmaksas pēc atlaides

            gala_summa.Text = gala_cena.ToString();//Pārvērš par string tipa mainīgo un izvada teksta laukā
            atlikums = sk1 - gala_cena;     //Aprēķina atlikumu
            daudzums_kg.Text = atlikums.ToString();//Pārvērš par string tipa mainīgo un izvada teksta laukā

            if (atlikums < 0)       //Pārbauda vai atlikums nav mazāks parnulli
            {
                MessageBox.Show("Jums nav pietiekami daudz naudas!!!");     //Izvada paziņojumu
            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void check0_CheckedChanged(object sender, EventArgs e)
                {
                    if(check0.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                        sk2 = 4.89;     //Piešķir mainīgajam vērtību
                    }
            
                }
        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
            if(check1.Checked == true)       //Pārbauda vai lauks atķeksēts
                {
                            sk3 = 17.63;     //Piešķir mainīgajam vērtību
                }
            }
            catch
            {
                MessageBox.Show("Nekorekti ievadits daudzums!");
            }
            
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if(check2.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                sk4 = 7.49;     //Piešķir mainīgajam vērtību
            }
        }

        private void check3_CheckedChanged(object sender, EventArgs e)
        {
            if(check3.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                sk5 = 12.19;     //Piešķir mainīgajam vērtību
            }
        }

        private void check4_CheckedChanged(object sender, EventArgs e)
        {
            
            if (check4.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                sk6 = 10.69;     //Piešķir mainīgajam vērtību
            }
        }

               private void check5_CheckedChanged(object sender, EventArgs e)
        {
            if (check5.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                sk7 = 14.99;     //Piešķir mainīgajam vērtību
            }
        }

        private void daudzums_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void text4_TextChanged(object sender, EventArgs e)
        {

        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void text6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vards;       //Definē string tipa mainīgo

            if(string.IsNullOrEmpty(vardaBox.Text))       //Pārbaudam vai lauks nav tukšs
            {
                MessageBox.Show("Lūdzu norādiet savu vārdu!");      //Izvada paziņojumu
            }

             vards = this.vardaBox.Text;        //Piešķir mainīgajam vērtību
            ierakstisana_faila( vards, rez0, rez1, rez2, rez3, rez4, rez5, kg0, kg1, kg2, kg3, kg4, kg5, sk1, sk2, sk3, sk4, sk5, sk6, sk7, summa, gala_atlaide, gala_cena, atlikums);      //Izsauc funkciju faila_ierakstisana

            MessageBox.Show("Paldies, ka iepirkāties mūsu veikalā");        //Izvada paziņojumu

            Application.Exit();     //Aizver programmu
        }

        private void daudzums_kg_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vardaBox_TextChanged(object sender, EventArgs e)
        {
            string vards = vardaBox.Text;       //Piešķir mainīgajam vērtību
        }

        private void izmaksas1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkatlaide.Checked == true)       //Pārbauda vai lauks atķeksēts
            {
                atlaide = 0.13;     //Piešķir mainīgajam vērtību
            }
        }
        static double Izmaksas0(double kg0, double sk2)     //Definē funkciju ar parametriem
        {
            double nauda0 = kg0* sk2;       //Definē un aprēķina preces izmaksas
            return nauda0;      //Atgriežs rezultātu
        }
                
        static double Izmaksas1(double kg1, double sk3)     //Definē funkciju ar parametriem
        {
            double nauda1 = kg1 * sk3;       //Definē un aprēķina preces izmaksas
            return nauda1;      //Atgriežs rezultātu
        }

        static double Izmaksas2(double kg2, double sk4)     //Definē funkciju ar parametriem
        {
            double nauda2 = kg2 * sk4;       //Definē un aprēķina preces izmaksas
            return nauda2;      //Atgriežs rezultātu
        }

        static double Izmaksas3(double kg3, double sk5)     //Definē funkciju ar parametriem
        {
            double nauda3 = kg3 * sk5;       //Definē un aprēķina preces izmaksas
            return nauda3;      //Atgriežs rezultātu
        }

        static double Izmaksas4(double kg4, double sk6)     //Definē funkciju ar parametriem
        {
            double nauda4 = kg4 * sk6;       //Definē un aprēķina preces izmaksas
            return nauda4;      //Atgriežs rezultātu
        }

        static double Izmaksas5(double kg5, double sk7)     //Definē funkciju ar parametriem
        {
            double nauda5 = kg5 * sk7;       //Definē un aprēķina preces izmaksas
            return nauda5;      //Atgriežs rezultātu
        }

        public static void ierakstisana_faila(string vards, double rez0, double rez1, double rez2, double rez3, double rez4, double rez5, double kg0,double kg1, double kg2, double kg3, double kg4, double kg5, double sk1, double sk2, double sk3, double sk4, double sk5, double sk6, double sk7, double summa, double gala_atlaide, double gala_cena, double atlikums)          //Definē funkciju ar parametriem 
        {
            string failanosaukums = vards + "_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + "_ceks.txt";       //Definē un piešķir nosaukumu string tipa mainīgajam                  
                         
            StreamWriter sw = new StreamWriter(failanosaukums);     //Faila izveidošana       

            sw.WriteLine("SIA <<RIMI>>");       //Ieraksta failā veikala nosaukumu
            sw.WriteLine(" ");       //Ieraksta failā

            if (rez0 != 0)      //Pārbauda vai izmaksas nav nulle
            {
                sw.WriteLine("Marmelāde");       //Ieraksta failā konfektes nosaukumu
                sw.WriteLine(kg0 + "kg x " + sk2 + "Eur = " + rez0 + "Eur");        //Ieraksta failā preces daudzmu, tās cenu un izmaksas
            }
            
            if (rez1 != 0)      //Pārbauda vai izmaksas nav nulle
            {
                sw.WriteLine("Konfektes serenāde");       //Ieraksta failā konfektes nosaukumu
                sw.WriteLine(kg1 + "kg x " + sk3 + "Eur = " + rez1 + "Eur");        //Ieraksta failā preces daudzmu, tās cenu un izmaksas
            }

            if (rez2 != 0)      //Pārbauda vai izmaksas nav nulle
            {
                sw.WriteLine("Konfektes Migle");       //Ieraksta failā konfektes nosaukumu
                sw.WriteLine(kg2 + "kg x " + sk4 + "Eur = " + rez2 + "Eur");        //Ieraksta failā preces daudzmu, tās cenu un izmaksas
            }

            if (rez3 != 0)      //Pārbauda vai izmaksas nav nulle
            {
                sw.WriteLine("Konfektes Rudzupuķe");       //Ieraksta failā konfektes nosaukumu
                sw.WriteLine(kg3 + "kg x " + sk5 + "Eur = " + rez3 + "Eur");        //Ieraksta failā preces daudzmu, tās cenu un izmaksas
            }

            if (rez4 != 0)      //Pārbauda vai izmaksas nav nulle
            {
                 sw.WriteLine("Konfektes Gotiņa");       //Ieraksta failā konfektes nosaukumu
                sw.WriteLine(kg4 + "kg x " + sk6 + "Eur = " + rez4 + "Eur");        //Ieraksta failā preces daudzmu, tās cenu un izmaksas
            }

            if (rez5 != 0)      //Pārbauda vai izmaksas nav nulle
            {
                sw.WriteLine("Konfektes Vētrasputns");       //Ieraksta failā konfektes nosaukumu
                sw.WriteLine(kg5 + "kg x " + sk7 + "Eur = " + rez5 + "Eur");        //Ieraksta failā preces daudzmu, tās cenu un izmaksas
            }

            sw.WriteLine(" ");       //Ieraksta failā 
            sw.WriteLine("Samaksai Eur " + summa);      //Ieraksta failā pirkuma izmaksas

            if(gala_atlaide != 0)//Pārbauda vai atlaide nav nulle
            {
            sw.WriteLine("Iegūtā atlaide Eur " + gala_atlaide)      ;//Ieraksta failā pirkuma atlaidi
            }
            
            sw.WriteLine("Samaksai pēc atlaides Eur " + gala_cena);     //Ieraksta failā pirkuma izmaksas pēc atlaides
            sw.WriteLine("Saņemtā nauda Eur " + sk1);       ////Ieraksta failā saņemto naudu
            sw.WriteLine("Izdotā nauda Eur " + atlikums);       //Ieraksta failā izdoto naudu
            sw.Close();       //Aizver failu
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
