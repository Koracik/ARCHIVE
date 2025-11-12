using System.Linq.Expressions;
using System.Windows.Forms.Design;
using System;
using System.Data;

namespace Calc
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private bool game1_()
        {

            return true;
        }
        List<string> simvol = new List<string>();
        List<int> numbers = new List<int>();

        public void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //1
            label1.Text += "1";


        }

        private void button15_Click(object sender, EventArgs e)
        {
            // /
            /*  if (koren)
              {
                  label1.Text += ")/";
                  koren = false;

              }
              else
              {
              }*/
            label1.Text += "/";
        }
        bool реверс_на_минус = false;
        private void button14_Click(object sender, EventArgs e)
        {
            /*реверс_на_минус = true;*/

            if (koren)
            {
                label1.Text += ")-";
                koren = false;

            }
            else
            {
                label1.Text += "-";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string new_label1 = "";
            for (int i = 0; i < label1.Text.Length - 1; i++)
            {
                new_label1 += label1.Text[i];
            }
            label1.Text = new_label1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //3
            label1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //*
            if (koren)
            {
                label1.Text += ")*";
                koren = false;

            }
            else
            {
                label1.Text += "*";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //2
            label1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //4
            label1.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //7
            label1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //0
            label1.Text += "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //8
            label1.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //5
            label1.Text += "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //6
            label1.Text += "6";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //9
            label1.Text += "9";
        }
        /*  List<int> s = new List<int>();
          bool ravno = false;
          int a = 0;*/



        /*bool n1;
        bool n2;

        double num1;
        double num2;

        bool znak_bool;
        bool znak_pered_num1_bool;
        bool znak_pered_num2_bool;

        string znak = "";
        string znak_pered_num1 = "";
        string znak_pered_num2 = "";*/

        /* public bool proverka_na_chislo_do_num1()
         {
             double num = double.Parse(label1.Text);
             if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 7 || num == 8 || num == 9 || num == 0)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }*/
        /* public void o(char x)
         {

             label1.Text += x;
             if (znak_pered_num1_bool == false)
             {
                 if (znal)
                 {

                 }
             }

         }*/
        /*  private bool game1_()
          {
              label1.Text = "";
              button10.BackColor = Color.DarkOrange;
              button21.BackColor = Color.DarkOrange;
              button1.Enabled = false;
              button2.Enabled = false;
              //button3.Enabled = false;
              button4.Enabled = false;
              button5.Enabled = false;
              button6.Enabled = false;
              button7.Enabled = false;
              button8.Enabled = false;
              button9.Enabled = false;
              button12.Enabled = false;
              button11.Enabled = false;
              button12.Enabled = false;
              //button13.Enabled = false;
              button14.Enabled = false;
              button15.Enabled = false;
              button16.Enabled = false;
              button17.Enabled = false;
              *//*button18.Enabled = false;*//*
              //button19.Enabled = false;
              button20.Enabled = false;
              game1 = true;
              return true;
          }*/
        bool dino;
        bool game1 = false;
        int count_bar = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "//")
            {
                label1.Text = "0";
                game2();
                progressBar1.Value = 0;
                label1.Text = "0";
            }

            else if (label1.Text == "0/0")
            {
                label2.Visible = true;
                label2.ForeColor = Color.Black;
                timer1.Enabled = true;
                label1.Visible = false;

                label1.Text = " ";
            }
            else if (label1.Text == "/")
            {
                button10.BackColor = Color.DarkOrange;
                button21.BackColor = Color.DarkOrange;
                button1.Enabled = false;
                button2.Enabled = false;
                //button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button12.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                //button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                /*button18.Enabled = false;*/
                //button19.Enabled = false;
                button20.Enabled = false;
                game1 = true;

            }

           
            if (game1 == true)
            {
                label1.Text = "0";
                var dt = new DataTable();
                var res = dt.Compute(label1.Text, null);
                label1.Text = res.ToString();
                if (int.Parse(label1.Text) > 100 && int.Parse(label1.Text) < 100000)
                {
                    label1.Text = "0";
                }
                if (int.Parse(label1.Text) >= 100)
                {
                    label1.Text = "100";
                }
                progressBar1.Value += int.Parse(label1.Text);
                label1.Text = "";
                if (progressBar1.Value >= 100)
                {
                    game1 = false;
                }
            }
            if (label1.Text == "/" || label1.Text == "//")
            {
                label1.Text = "0";
            }

            if (game1 == false)
            {
                /*if (dino == true)
                {*/
                progressBar1.Enabled = false;
                progressBar1.Value = 0;


                button10.BackColor = Color.Gainsboro;
                button21.BackColor = Color.PapayaWhip;
                button1.Enabled = true;
                button2.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button12.Enabled = true;
                button11.Enabled = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                button16.Enabled = true;
                button17.Enabled = true;
                button3.Enabled = true;
                /*button18.Enabled = true;*/
                button19.Enabled = true;
                button20.Enabled = true;
                label2.BackColor = Color.Transparent;
                label1.Text = label1.Text.Replace(',', '.');

                var dt = new DataTable();
                var res = dt.Compute(label1.Text, null);
                label1.Text = res.ToString();


                //209; 20
                /*for (int i = 0; i < 100; i++)
                {
                    timer1.Enabled = true;
                    label2.Left -= 5;
                    //label2.Location = new Point(209, c--);
                }*/
                //label2.Visible = false;
                // c = 20;

            }
            dino = false;
            if (label1.Text == "666")
            {
                MessageBox.Show("Иди в церковь умойся святой водой", "БОГАХУЛЬНИК!!!!!");
            }
            if (label1.Text == "911" || label1.Text == "112")
            {
                MessageBox.Show("Помощи не будет", "SOS");
            }



            //var expr = new Expression(label1.Text);

            /*bool o = false;

            string number = "";
            for (int i = 0; i < label1.Text.Length; i++)
            {
                if (label1.Text[i] == '+')
                {
                    simvol.Add("+");
                    o = true;
                }
                else if (label1.Text[i] == '-')
                {
                    simvol.Add("-");
                    o = true;
                }
                else if (label1.Text[i] == '/')
                {
                    simvol.Add("/");
                    o = true;
                }
                else if (label1.Text[i] == '*')
                {
                    simvol.Add("*");
                    o = true;
                }
                else if (label1.Text[i] == '²')
                {
                    simvol.Add("**");
                    o = true;
                }
                else if (label1.Text[i] == '√')
                {
                    simvol.Add("корень");
                    o = true;
                }

                if (o)
                {
                    numbers.Add(int.Parse(number));
                    number = " ";
                }
                else
                {
                    number += $"{label1.Text[i]}";
                }
            }
            for (int i = 0; numbers.Count > i && simvol.Count > i; i++)
            {
                if (simvol[i] == "+")
                {
                    if (number.Length - 1 > i)
                    {

                    }
                }
            }*/

        }



        private void button21_Click(object sender, EventArgs e)
        {
            //+
            if (koren)
            {
                label1.Text += ")+";
                koren = false;

            }
            else
            {
                label1.Text += "+";
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text += "(";
        }
        bool koren = false;
        private void button20_Click(object sender, EventArgs e)
        {


            /*, Convert.ToInt32(label1.Text[label1.Text.Length - 1])*/
            //koren = true;
            label1.Text += ")";




        }
        int c = 20;
        private void label2_Click(object sender, EventArgs e)
        {



        }

        int jn = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            jn++;
            label2.Left -= 5;

            if (jn == 20)
            {
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.portall;
            }
            else if (jn == 80)
            {
                label1.Visible = true;
                label2.Location = new Point(217, 20);
                label2.Visible = false;
                timer1.Enabled = false;
                label2.ForeColor = Color.PaleTurquoise;
                jn = 0;
                pictureBox2.Image = null;
                pictureBox2.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

















        string _num;
        Random r = new Random();
        private void game2()
        {
            timer2.Enabled = true;
        }

        async private void timer2_Tick(object sender, EventArgs e)
        {
            int num = r.Next(0, 10);
            _num = num.ToString();
            switch (num)
            {
                case 0:
                    button6.BackColor = Color.LightSalmon;
                    break;
                case 1:
                    button10.BackColor = Color.LightSalmon;
                    break;
                case 2:
                    button11.BackColor = Color.LightSalmon;
                    break;
                case 3:
                    button12.BackColor = Color.LightSalmon;
                    break;
                case 4:
                    button9.BackColor = Color.LightSalmon;
                    break;
                case 5:
                    button4.BackColor = Color.LightSalmon;
                    break;
                case 6:
                    button2.BackColor = Color.LightSalmon;
                    break;
                case 7:
                    button8.BackColor = Color.LightSalmon;
                    break;
                case 8:
                    button5.BackColor = Color.LightSalmon;
                    break;
                case 9:
                    button1.BackColor = Color.LightSalmon;
                    break;

                default:
                    break;
            }
            timer3.Enabled = true;

            if (timer2.Interval > 750)
            {
             timer2.Interval -= 50;
             timer3.Interval -= 50;
            }

            if (progressBar1.Value == 100)
            {
                timer2.Enabled = false;
                progressBar1.Value = 0;
                button6.BackColor = Color.Gainsboro;
                button10.BackColor = Color.Gainsboro;
                button12.BackColor = Color.Gainsboro;
                button9.BackColor = Color.Gainsboro;
                button4.BackColor = Color.Gainsboro;
                button2.BackColor = Color.Gainsboro;
                button8.BackColor = Color.Gainsboro;
                button5.BackColor = Color.Gainsboro;
                button1.BackColor = Color.Gainsboro;
                button11.BackColor = Color.Gainsboro;
            }
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label1.Text[label1.Text.Length - 1].ToString() == _num)
            {
                progressBar1.Value += 5;
            }
            else if(progressBar1.Value > 0)
            {
                progressBar1.Value -= 5;
            }
            button6.BackColor = Color.Gainsboro;
            button10.BackColor = Color.Gainsboro;
            button12.BackColor = Color.Gainsboro;
            button9.BackColor = Color.Gainsboro;
            button4.BackColor = Color.Gainsboro;
            button2.BackColor = Color.Gainsboro;
            button8.BackColor = Color.Gainsboro;
            button5.BackColor = Color.Gainsboro;
            button1.BackColor = Color.Gainsboro;
            button11.BackColor = Color.Gainsboro;
            timer3.Enabled = false;
            label1.Text = "0";
        }
    }
}