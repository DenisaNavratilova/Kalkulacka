using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Kalkulačka
{
    public partial class Form1 : Form
    {
        string symbol = "";
        string lastSymbol = "";
        double actualValue;
        double addedValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void nula_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + nula.Text;
        }

        private void jedna_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + jedna.Text;
        }
        
        private void dva_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + dva.Text;
        }

        private void tri_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + tri.Text;
        }

        private void ctyri_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ctyri.Text;
        }

        private void pet_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + pet.Text;
        }

        private void sest_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + sest.Text;
        }

        private void sedm_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + sedm.Text;
        }

        private void osm_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + osm.Text;
        }

        private void devet_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + devet.Text;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            addedValue = 0;
            actualValue = 0;
            symbol = "";
            lastSymbol = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            symbol = "<-";
            if (textBox1.Text == "")
            {
                MessageBox.Show("Nejdřív zadejte hodnotu");
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void carka_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0,";
            }
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + carka.Text;
            }
        }

        private void deleno_Click(object sender, EventArgs e)
        {
            NoValue();

            if (textBox1.Text == "")
            {
                symbol = "/";
            }
            else
            {
                if (actualValue != 0)
                {
                    Count();
                }

                if (addedValue == 0)
                {
                    AddValue();
                }
                symbol = "/";
            }
            lastSymbol = symbol;
        }

        private void krat_Click(object sender, EventArgs e)
        {
            NoValue();

            if (textBox1.Text == "")
            {
                symbol = "*";
            }
            else
            {
                if (actualValue != 0)
                {
                    Count();
                }

                if (addedValue == 0)
                {
                    AddValue();
                }
                symbol = "*";
            }
            lastSymbol = symbol;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            NoValue();

            if (textBox1.Text == "")
            {
                symbol = "+";
            }
            else
            {
                if (actualValue != 0)
                {
                    Count();
                }

                if (addedValue == 0)
                {
                    AddValue();
                }
                symbol = "+";
            }
            lastSymbol = symbol;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            else
            {
                if (actualValue != 0)
                {
                    Count();
                }

                if (addedValue == 0)
                {
                    AddValue();
                }
                symbol = "-";
            }
            lastSymbol = symbol;
        }

        private void mocnina_Click(object sender, EventArgs e)
        {
            symbol = "^2";

            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                MessageBox.Show("Nejdřív zadejte hodnotu");
            }
            
            else if (addedValue == 0 || lastSymbol == "^2" || lastSymbol == "√" || lastSymbol == "=")
            {
                AddValue();
            }

            else
            {
                Count();
            }
            lastSymbol = symbol;
        }

        private void odmocnina_Click(object sender, EventArgs e)
        {
            symbol = "√";

            if (textBox1.Text == "" || textBox1.Text == "-")
            {
                MessageBox.Show("Nejdřív zadejte hodnotu");
            }

            else if (addedValue == 0 || lastSymbol == "√" || lastSymbol == "^2" || lastSymbol == "=")
            {
                AddValue();
            }

            else
            {
                Count();
            }
            lastSymbol = symbol;
        }

        private void rovnase_Click(object sender, EventArgs e)
        {
            NoValue();

            if (textBox1.Text == "-")
            {
                MessageBox.Show("Nejdřív zadejte hodnotu");
            }

            if (textBox1.Text == "")
            {
                symbol = "=";
            }

            if (!textBox1.Text.Contains("E"))
            {
                if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/" || symbol == "=" && lastSymbol != "=")
                {
                    Count();
                    textBox1.Text = actualValue + "";
                    actualValue = 0;
                    addedValue = 0;
                    symbol = "=";
                }
            }
            lastSymbol = "=";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            textBox1.AutoSize = false;
            textBox1.Size = new Size(320, 60);

            if (textBox1.Text.Length < 12)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 35);
            }

            if (textBox1.Text.Length > 12)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 19);
            }

            if (textBox1.Text.Length > 22)
            {
                MessageBox.Show("Příliš mnoho znaků");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text.Length > 1 && textBox1.Text == "00")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text.Contains("∞"))
            {
                MessageBox.Show("S touto hodnotou nelze dále pracovat");
                textBox1.Clear();
                actualValue = 0;
                addedValue = 0;
            }

            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                MessageBox.Show("Nelze vypočítat odmocninu ze záporného čísla");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && textBox1.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        public void Count()
        {
            if (!textBox1.Text.Contains("E"))
            {
                if (textBox1.Text == "-")
                {
                    MessageBox.Show("Nejdřív zadejte hodnotu");
                }

                else if (symbol == "*")
                {
                    addedValue = double.Parse(textBox1.Text);
                    actualValue = actualValue * addedValue;
                    textBox1.Clear();
                }

                else if (symbol == "/")
                {
                    addedValue = double.Parse(textBox1.Text);

                    if (addedValue == 0)
                    {
                        textBox1.Clear();
                        MessageBox.Show("Nelze dělit nulou");
                    }
                    else
                    {
                        actualValue = actualValue / addedValue;
                        textBox1.Clear();
                    }
                }

                else if (symbol == "+")
                {
                    addedValue = double.Parse(textBox1.Text);
                    actualValue = actualValue + addedValue;
                    textBox1.Clear();
                }

                else if (symbol == "-")
                {
                    addedValue = double.Parse(textBox1.Text);
                    actualValue = actualValue - addedValue;
                    textBox1.Clear();
                }

                else if (symbol == "^2")
                {
                    addedValue = double.Parse(textBox1.Text);

                    if (lastSymbol == "+")
                    {
                        actualValue = actualValue + (Math.Pow(addedValue, 2));
                    }

                    if (lastSymbol == "-")
                    {
                        actualValue = actualValue - (Math.Pow(addedValue, 2));
                    }
                    if (lastSymbol == "*")
                    {
                        actualValue = actualValue * (Math.Pow(addedValue, 2));
                    }
                    if (lastSymbol == "/")
                    {
                        actualValue = actualValue / (Math.Pow(addedValue, 2)); ;
                    }
                    textBox1.Text = actualValue + "";
                    symbol = "";
                    actualValue = 0;
                    addedValue = 0;
                }

                else if (symbol == "√")
                {
                    addedValue = double.Parse(textBox1.Text);

                    if (lastSymbol == "+")
                    {
                        actualValue = actualValue + (Math.Sqrt(addedValue));
                    }
                    if (lastSymbol == "-")
                    {
                        actualValue = actualValue - (Math.Sqrt(addedValue));
                    }
                    if (lastSymbol == "*")
                    {
                        actualValue = actualValue * (Math.Sqrt(addedValue));
                    }
                    if (lastSymbol == "/")
                    {
                        actualValue = actualValue / (Math.Sqrt(addedValue));
                    }
                    textBox1.Text = actualValue + "";
                    symbol = "";
                    actualValue = 0;
                    addedValue = 0;
                }
            }
        }

        public void AddValue()
        {
            if (textBox1.Text == "-")
            {
                MessageBox.Show("Nejdřív zadejte hodnotu");
            }

            else if (symbol == "^2")
            {
                addedValue = double.Parse(textBox1.Text);
                actualValue = (Math.Pow(addedValue, 2));
                textBox1.Text = actualValue + "";
            }
            else if (symbol == "√")
            {
                addedValue = double.Parse(textBox1.Text);
                actualValue = (Math.Sqrt(addedValue));
                textBox1.Text = actualValue + "";
            }

            else if(!textBox1.Text.Contains("E") && symbol!= "^2" && symbol!= "√")
            {
                addedValue = double.Parse(textBox1.Text);
                actualValue = addedValue;
                textBox1.Clear();
            }
        }

        public void NoValue()
        {
            if (textBox1.Text == "" && actualValue == 0)
            {
                MessageBox.Show("Nejdřív zadejte hodnotu");
            }
        }
    }
}