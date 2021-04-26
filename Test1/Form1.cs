using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифри від 0 до 9, Backspace ,кома в ASCII
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифри від 0 до 9, Backspace в ASCII
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифри від 0 до 9, Backspace ,кома в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифри від 0 до 9, Backspace в ASCII
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифри від 0 до 9, Backspace ,кома в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифри від 0 до 9, Backspace в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифри від 0 до 9, Backspace ,кома в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифри від 0 до 9, Backspace в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифри від 0 до 9, Backspace ,кома в ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8) //цифри від 0 до 9, Backspace в ASCII
            {
                e.Handled = true;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e) //Тетраедр
        {
            {

                if (textBox2.Text == "")
                {
                    double a_ts = double.Parse(textBox1.Text);     //Площа
                    double c_ts = Convert.ToDouble(Math.Pow(a_ts, 2));
                    double d_ts = Math.Sqrt(3);
                    double f_ts = c_ts * d_ts;
                    label1.Text = Convert.ToString($"S={f_ts}");
                }
                else
                {
                    int h_ts1 = Convert.ToInt32(textBox2.Text);
                    double a_ts1 = double.Parse(textBox1.Text);     //Площа
                    double c_ts1 = Convert.ToDouble(Math.Pow(a_ts1, 2));
                    double d_ts1 = Math.Sqrt(3);
                    double f_ts1 = c_ts1 * d_ts1;
                    double j_ts1 = Math.Round(f_ts1, h_ts1);
                    label1.Text = Convert.ToString($"S={j_ts1}");
                }
            }

            {
                if (textBox2.Text == "")
                {
                    double a_tv = double.Parse(textBox1.Text);    //Об'єм
                    double c_tv = Convert.ToDouble(Math.Pow(a_tv, 3));
                    double d_tv = Math.Sqrt(2);
                    double f_tv = d_tv / 12;
                    double g_tv = f_tv * c_tv;
                    label2.Text = Convert.ToString($"V={g_tv}");
                }
                else
                {
                    int h_tv1 = Convert.ToInt32(textBox2.Text);
                    double a_tv1 = double.Parse(textBox1.Text);    //Об'єм
                    double c_tv1 = Convert.ToDouble(Math.Pow(a_tv1, 3));
                    double d_tv1 = Math.Sqrt(2);
                    double f_tv1 = d_tv1 / 12;
                    double g_tv1 = f_tv1 * c_tv1;
                    double j_tv1 = Math.Round(g_tv1, h_tv1);
                    label2.Text = Convert.ToString($"V={j_tv1}");
                }
            }
            {
                if (textBox2.Text == "")
                {
                    double a_tR = double.Parse(textBox1.Text);    //Радіус описаної сфери
                    double d_tR = Math.Sqrt(6);
                    double f_tR = d_tR / 4;
                    double g_tR = f_tR * a_tR;
                    label3.Text = Convert.ToString($"R={g_tR}");
                }
                else
                {
                    int h_tR1 = Convert.ToInt32(textBox2.Text);
                    double a_tR1 = double.Parse(textBox1.Text);    //Радіус описаної сфери
                    double d_tR1 = Math.Sqrt(6);
                    double f_tR1 = d_tR1 / 4;
                    double g_tR1 = f_tR1 * a_tR1;
                    double j_tR1 = Math.Round(g_tR1, h_tR1);
                    label3.Text = Convert.ToString($"R={j_tR1}");
                }
            }
            {
                if (textBox2.Text == "")
                {
                    double a_tr = double.Parse(textBox1.Text);    //Радіус вписаної сфери
                    double d_tr = Math.Sqrt(6);
                    double f_tr = d_tr / 12;
                    double g_tr = f_tr * a_tr;
                    label4.Text = Convert.ToString($"r={g_tr}");
                }
                else
                {
                    int h_tr1 = Convert.ToInt32(textBox2.Text);
                    double a_tr1 = double.Parse(textBox1.Text);    //Радіус вписаної сфери
                    double d_tr1 = Math.Sqrt(6);
                    double f_tr1 = d_tr1 / 12;
                    double g_tr1 = f_tr1 * a_tr1;
                    double j_tr1 = Math.Round(g_tr1, h_tr1);
                    label4.Text = Convert.ToString($"r={j_tr1}");
                }
            }
        }
        private void button3_Click(object sender, EventArgs e) //Куб
        {
            {

                if (textBox6.Text == "")
                {
                    double a_сs = double.Parse(textBox5.Text);     //Площа
                    double c_сs = Convert.ToDouble(Math.Pow(a_сs, 2));
                    double f_сs = c_сs * 6;
                    label16.Text = Convert.ToString($"S={f_сs}");
                }
                else
                {
                    int h_tс1 = Convert.ToInt32(textBox6.Text);
                    double a_tс1 = double.Parse(textBox5.Text);     //Площа
                    double c_tс1 = Convert.ToDouble(Math.Pow(a_tс1, 2));
                    double f_tс1 = c_tс1 * 6;
                    double j_tс1 = Math.Round(f_tс1, h_tс1);
                    label16.Text = Convert.ToString($"S={j_tс1}");
                }
            }

            {
                if (textBox6.Text == "")
                {
                    double a_cv = double.Parse(textBox5.Text);    //Об'єм
                    double c_cv = Convert.ToDouble(Math.Pow(a_cv, 3));
                    label21.Text = Convert.ToString($"V={c_cv}");
                }
                else
                {
                    int h_cv1 = Convert.ToInt32(textBox6.Text);
                    double a_cv1 = double.Parse(textBox5.Text);    //Об'єм
                    double c_cv1 = Convert.ToDouble(Math.Pow(a_cv1, 3));
                    double j_cv1 = Math.Round(c_cv1, h_cv1);
                    label21.Text = Convert.ToString($"V={j_cv1}");
                }
            }
            {
                if (textBox6.Text == "")
                {
                    double a_cR = double.Parse(textBox5.Text);    //Радіус описаної сфери
                    double d_cR = Math.Sqrt(3);
                    double f_cR = d_cR / 2;
                    double g_cR = f_cR * a_cR;
                    label22.Text = Convert.ToString($"R={g_cR}");
                }
                else
                {
                    int h_cR1 = Convert.ToInt32(textBox6.Text);
                    double a_cR1 = double.Parse(textBox5.Text);    //Радіус описаної сфери
                    double d_cR1 = Math.Sqrt(3);
                    double f_cR1 = d_cR1 / 2;
                    double g_cR1 = f_cR1 * a_cR1;
                    double j_cR1 = Math.Round(g_cR1, h_cR1);
                    label22.Text = Convert.ToString($"R={j_cR1}");
                }
            }
            {
                if (textBox6.Text == "")
                {
                    double a_cr = double.Parse(textBox5.Text);    //Радіус вписаної сфери
                    double g_cr = 0.5 * a_cr;
                    label23.Text = Convert.ToString($"r={g_cr}");
                }
                else
                {
                    int h_cr1 = Convert.ToInt32(textBox6.Text);
                    double a_cr1 = double.Parse(textBox5.Text);    //Радіус вписаної сфери
                    double g_cr1 = 0.5 * a_cr1;
                    double j_cr1 = Math.Round(g_cr1, h_cr1);
                    label23.Text = Convert.ToString($"r={j_cr1}");
                }
            }
        }
        private void button4_Click(object sender, EventArgs e) // Октаедр
        {
            if (textBox4.Text == "")
            {
                double a_os = double.Parse(textBox3.Text);     //Площа
                double c_os = Convert.ToDouble(Math.Pow(a_os, 2));
                double d_os = Math.Sqrt(3);
                double f_os = c_os * d_os * 2;
                label17.Text = Convert.ToString($"S={f_os}");
            }
            else
            {
                int h_os1 = Convert.ToInt32(textBox4.Text);
                double a_os1 = double.Parse(textBox3.Text);     //Площа
                double c_os1 = Convert.ToDouble(Math.Pow(a_os1, 2));
                double d_os1 = Math.Sqrt(3);
                double f_os1 = c_os1 * d_os1 * 2;
                double j_os1 = Math.Round(f_os1, h_os1);
                label17.Text = Convert.ToString($"S={j_os1}");
            }
            {
                if (textBox4.Text == "")
                {
                    double a_ov = double.Parse(textBox3.Text);     //Об'єм
                    double c_ov = Convert.ToDouble(Math.Pow(a_ov, 3));
                    double d_ov = Math.Sqrt(2);
                    double f_ov = c_ov * d_ov / 3;
                    label18.Text = Convert.ToString($"V={f_ov}");
                }
                else
                {
                    int h_ov1 = Convert.ToInt32(textBox4.Text);
                    double a_ov1 = double.Parse(textBox3.Text);     //Об'єм
                    double c_ov1 = Convert.ToDouble(Math.Pow(a_ov1, 3));
                    double d_ov1 = Math.Sqrt(2);
                    double f_ov1 = c_ov1 * d_ov1 / 3;
                    double j_ov1 = Math.Round(f_ov1, h_ov1);
                    label18.Text = Convert.ToString($"V={j_ov1}");
                }
            }
            {
                if (textBox4.Text == "")
                {
                    double a_oR = double.Parse(textBox3.Text);     //Радіус описаної сфери
                    double c_oR = a_oR / 2;
                    double d_oR = Math.Sqrt(2);
                    double f_oR = c_oR * d_oR;
                    label19.Text = Convert.ToString($"R={f_oR}");
                }
                else
                {
                    int h_oR1 = Convert.ToInt32(textBox4.Text);
                    double a_oR1 = double.Parse(textBox3.Text);     //Радіус описаної сфери
                    double c_oR1 = a_oR1 / 2;
                    double d_oR1 = Math.Sqrt(2);
                    double f_oR1 = c_oR1 * d_oR1;
                    double j_oR1 = Math.Round(f_oR1, h_oR1);
                    label19.Text = Convert.ToString($"R={j_oR1}");
                }
            }
            {
                if (textBox4.Text == "")
                {
                    double a_or = double.Parse(textBox3.Text);     //Радіус вписаної сфери
                    double d_or = Math.Sqrt(6);
                    double c_or = a_or / 6;
                    double f_or = c_or * d_or;
                    label20.Text = Convert.ToString($"r={f_or}");
                }
                else
                {
                    int h_or1 = Convert.ToInt32(textBox4.Text);
                    double a_or1 = double.Parse(textBox3.Text);     //Радіус вписаної сфери
                    double d_or1 = Math.Sqrt(6);
                    double c_or1 = a_or1 / 6;
                    double f_or1 = c_or1 * d_or1;
                    double j_or1 = Math.Round(f_or1, h_or1);
                    label20.Text = Convert.ToString($"r={j_or1}");

                }
            }
        }
        private void button5_Click(object sender, EventArgs e) //Ікосайдер
        {
            if (textBox8.Text == "")
            {
                double a_is = double.Parse(textBox7.Text);     //Площа
                double c_is = Convert.ToDouble(Math.Pow(a_is, 2));
                double d_is = Math.Sqrt(3);
                double f_is = c_is * d_is * 5;
                label24.Text = Convert.ToString($"S={f_is}");
            }
            else
            {
                int h_is1 = Convert.ToInt32(textBox8.Text);
                double a_is1 = double.Parse(textBox7.Text);     //Площа
                double c_is1 = Convert.ToDouble(Math.Pow(a_is1, 2));
                double d_is1 = Math.Sqrt(3);
                double f_is1 = c_is1 * d_is1 * 5;
                double j_is1 = Math.Round(f_is1, h_is1);
                label24.Text = Convert.ToString($"S={j_is1}");
            }
            {
                if (textBox8.Text == "")
                {
                    double a_iv = double.Parse(textBox7.Text);     //Об'єм
                    double c_iv = Convert.ToDouble(Math.Pow(a_iv, 3));
                    double d_iv = Math.Sqrt(5);
                    double t_iv = d_iv + 3;
                    double f_iv = (5 * c_iv * t_iv) / 12;
                    label25.Text = Convert.ToString($"V={f_iv}");
                }
                else
                {
                    int h_iv1 = Convert.ToInt32(textBox8.Text);
                    double a_iv1 = double.Parse(textBox7.Text);     //Об'єм
                    double c_iv1 = Convert.ToDouble(Math.Pow(a_iv1, 3));
                    double d_iv1 = Math.Sqrt(5);
                    double t_iv1 = d_iv1 + 3;
                    double f_iv1 = (5 * c_iv1 * t_iv1) / 12;
                    double j_iv1 = Math.Round(f_iv1, h_iv1);
                    label25.Text = Convert.ToString($"V={j_iv1}");
                }
            }
            {
                if (textBox8.Text == "")
                {
                    double a_iR = double.Parse(textBox7.Text);
                    double t_iR = Math.Sqrt(5);               //Радіус описаної сфери
                    double e_iR = (5 + t_iR);
                    double c_iR = a_iR * Math.Sqrt(2 * e_iR);
                    double f_iR = c_iR / 4;
                    label26.Text = Convert.ToString($"R={f_iR}");
                }
                else
                {
                    int h_iR1 = Convert.ToInt32(textBox8.Text);
                    double a_iR1 = double.Parse(textBox7.Text);
                    double t_iR1 = Math.Sqrt(5);               //Радіус описаної сфери
                    double e_iR1 = (5 + t_iR1);
                    double c_iR1 = a_iR1 * Math.Sqrt(2 * e_iR1);
                    double f_iR1 = c_iR1 / 4;
                    double j_iR1 = Math.Round(f_iR1, h_iR1);
                    label26.Text = Convert.ToString($"R={j_iR1}");
                }
            }
            {
                if (textBox8.Text == "")
                {
                    double a_ir = double.Parse(textBox7.Text);
                    double d_ir = 3 + Math.Sqrt(5);
                    double t_ir = Math.Sqrt(3 * d_ir);               //Радіус вписаної сфери
                    double c_ir = a_ir * t_ir;
                    double f_ir = c_ir / 12;
                    label27.Text = Convert.ToString($"r={f_ir}");
                }
                else
                {
                    int h_ir1 = Convert.ToInt32(textBox8.Text);
                    double a_ir1 = double.Parse(textBox7.Text);
                    double d_ir1 = 3 + Math.Sqrt(5);
                    double t_ir1 = Math.Sqrt(3 * d_ir1);               //Радіус вписаної сфери
                    double c_ir1 = a_ir1 * t_ir1;
                    double f_ir1 = c_ir1 / 12;
                    double j_ir1 = Math.Round(f_ir1, h_ir1);
                    label27.Text = Convert.ToString($"r={j_ir1}");

                }
            }
        }
        private void button6_Click(object sender, EventArgs e) // Додекайдер
        {
            if (textBox9.Text == "")
            {
                double a_ds = double.Parse(textBox10.Text);     //Площа
                double c_ds = Convert.ToDouble(Math.Pow(a_ds, 2));
                double d_ds = Math.Sqrt(5);
                double b_ds = 5 + (2 * d_ds);
                double e_ds = Math.Sqrt(5 * b_ds);
                double f_ds = e_ds * c_ds * 3;
                label28.Text = Convert.ToString($"S={f_ds}");
            }
            else
            {
                int h_ds1 = Convert.ToInt32(textBox9.Text);
                double a_ds1 = double.Parse(textBox10.Text);     //Площа
                double c_ds1 = Convert.ToDouble(Math.Pow(a_ds1, 2));
                double d_ds1 = Math.Sqrt(5);
                double b_ds1 = 5 + (2 * d_ds1);
                double e_ds1 = Math.Sqrt(5 * b_ds1);
                double f_ds1 = e_ds1 * c_ds1 * 3;
                double j_ds1 = Math.Round(f_ds1, h_ds1);
                label28.Text = Convert.ToString($"S={j_ds1}");
            }
            {
                if (textBox9.Text == "")
                {
                    double a_dv = double.Parse(textBox10.Text);     //Об'єм
                    double c_dv = Convert.ToDouble(Math.Pow(a_dv, 3));
                    double d_dv = Math.Sqrt(5);
                    double t_dv = (d_dv * 7) + 15;
                    double f_dv = (c_dv * t_dv) / 4;
                    label29.Text = Convert.ToString($"V={f_dv}");
                }
                else
                {
                    int h_dv1 = Convert.ToInt32(textBox9.Text);
                    double a_dv1 = double.Parse(textBox10.Text);     //Об'єм
                    double c_dv1 = Convert.ToDouble(Math.Pow(a_dv1, 3));
                    double d_dv1 = Math.Sqrt(5);
                    double t_dv1 = (d_dv1 * 7) + 15;
                    double f_dv1 = (c_dv1 * t_dv1) / 4;
                    double j_dv1 = Math.Round(f_dv1, h_dv1);
                    label29.Text = Convert.ToString($"V={j_dv1}");
                }
            }
            {
                if (textBox9.Text == "")
                {
                    double a_dR = double.Parse(textBox10.Text);
                    double d_dR = Math.Sqrt(3);
                    double t_dR = Math.Sqrt(5);               //Радіус описаної сфери
                    double c_dR = a_dR * d_dR * (1 + t_dR);
                    double f_dR = c_dR / 4;
                    label30.Text = Convert.ToString($"R={f_dR}");
                }
                else
                {
                    int h_dR1 = Convert.ToInt32(textBox9.Text);
                    double a_dR1 = double.Parse(textBox10.Text);
                    double d_dR1 = Math.Sqrt(3);
                    double t_dR1 = Math.Sqrt(5);               //Радіус описаної сфери
                    double c_dR1 = a_dR1 * d_dR1 * (1 + t_dR1);
                    double f_dR1 = c_dR1 / 4;
                    double j_dR1 = Math.Round(f_dR1, h_dR1);
                    label30.Text = Convert.ToString($"R={j_dR1}");
                }
            }
            {
                if (textBox9.Text == "")
                {
                    double a_dr = double.Parse(textBox10.Text);
                    double d_dr = Math.Sqrt(5);
                    double t_dr = 25 + (11 * d_dr);              //Радіус вписаної сфери
                    double c_dr = a_dr * Math.Sqrt(10 * t_dr);
                    double f_dr = c_dr / 20;
                    label31.Text = Convert.ToString($"R= {f_dr}");
                }
                else
                {
                    int h_dr1 = Convert.ToInt32(textBox9.Text);
                    double a_dr1 = double.Parse(textBox10.Text);
                    double d_dr1 = Math.Sqrt(5);
                    double t_dr1 = 25 + (11 * d_dr1);              //Радіус вписаної сфери
                    double c_dr1 = a_dr1 * Math.Sqrt(10 * t_dr1);
                    double f_dr1 = c_dr1 / 20;
                    double j_dr1 = Math.Round(f_dr1, h_dr1);
                    label31.Text = Convert.ToString($"r= {j_dr1}");

                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/Правильний_тетраедр");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/Куб");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/Октаедр");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/Правильний_ікосаедр");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/Правильний_додекаедр");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = File.ReadAllText("1.txt");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label32.Text = File.ReadAllText("2.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label33.Text = File.ReadAllText("3.txt");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label34.Text = File.ReadAllText("4.txt");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label35.Text = File.ReadAllText("5.txt");
        }
        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            label16.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label32.Text = "";
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label33.Text = "";
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
            label34.Text = "";
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label28.Text = "";
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label35.Text = "";
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
           textBox11.Text +=textBox1.Text + Environment.NewLine+label1.Text + Environment.NewLine + label2.Text + Environment.NewLine + label3.Text + Environment.NewLine + label4.Text + Environment.NewLine;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox12.Text += textBox5.Text + Environment.NewLine + label16.Text + Environment.NewLine + label21.Text + Environment.NewLine + label22.Text + Environment.NewLine + label23.Text + Environment.NewLine;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
        }
        private void button21_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox13.Text += textBox3.Text + Environment.NewLine + label17.Text + Environment.NewLine + label18.Text + Environment.NewLine + label19.Text + Environment.NewLine + label20.Text + Environment.NewLine;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox14.Text += textBox7.Text + Environment.NewLine + label24.Text + Environment.NewLine + label25.Text + Environment.NewLine + label26.Text + Environment.NewLine + label27.Text + Environment.NewLine;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox15.Text += textBox10.Text + Environment.NewLine + label28.Text + Environment.NewLine + label29.Text + Environment.NewLine + label30.Text + Environment.NewLine + label31.Text + Environment.NewLine;
        }
    }
}


