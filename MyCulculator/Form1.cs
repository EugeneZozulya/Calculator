using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCulculator
{
    public partial class Form1 : Form
    {
        Calculator calculator;
        bool isEmptyString = false;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }
        /// <summary>
        /// Button "1" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_1_Click(object sender, EventArgs e) => SymvolsButtons('1');
        /// <summary>
        /// Button "2" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_2_Click(object sender, EventArgs e) => SymvolsButtons('2');
        /// <summary>
        /// Button "3" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_3_Click(object sender, EventArgs e) => SymvolsButtons('3');
        /// <summary>
        /// Button "4" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_4_Click(object sender, EventArgs e) => SymvolsButtons('4');
        /// <summary>
        /// Button "5" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_5_Click(object sender, EventArgs e) => SymvolsButtons('5');
        /// <summary>
        /// Button "6" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_6_Click(object sender, EventArgs e) => SymvolsButtons('6');
        /// <summary>
        /// Button "7" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_7_Click(object sender, EventArgs e) => SymvolsButtons('7');
        /// <summary>
        /// Button "8" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_8_Click(object sender, EventArgs e) => SymvolsButtons('8');
        /// <summary>
        /// Button "9" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_9_Click(object sender, EventArgs e) => SymvolsButtons('9');
        /// <summary>
        /// Button "," click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Point_Click(object sender, EventArgs e) => SymvolsButtons(',');
        /// <summary>
        /// Button "0" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void button_0_Click(object sender, EventArgs e) => SymvolsButtons('0');
        /// <summary>
        /// Button "Clear" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Clear_Click(object sender, EventArgs e)
        { 
            textBox1.Clear();
            history.Text = "";
            textBox1.Focus();
            calculator.Clear();
            calculator.MemoryClear();
            FreeButtons();
        }
        /// <summary>
        /// Button "BACKSPACE" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void BackSpace_Click(object sender, EventArgs e) => SymvolsButtons('b');
        /// <summary>
        /// Button "Sub" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Sub_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || (textBox1.TextLength == 1 && textBox1.Text == "+"))
            {
                textBox1.Text = "-";
                this.textBox1.Focus();
                this.textBox1.SelectionStart = textBox1.TextLength;
            }
            else
            {
                if (!CanPress()) return;
                OperationButtons();
                history.Text += " - ";
                Sub.Enabled = false;
            }
        }
        /// <summary>
        /// Button "Equal" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                 if (calculator.Put_a==0 || (textBox1.TextLength == 1 && (textBox1.Text == "+" || textBox1.Text == "-"))) return;
                double temp = default;
                if (textBox1.TextLength > 0)
                {
                    temp = Convert.ToDouble(textBox1.Text);
                    if (!Sum.Enabled && temp < 0) history.Text = history.Text.Remove(history.Text.Length - 3);
                    history.Text += temp.ToString() + " = ";
                }
                else if (!Notch.Enabled || !Cos.Enabled || !OneDivX.Enabled) history.Text += " = ";
                else history.Text = history.Text.Remove(history.Text.Length - 3) + " = ";
                if (!Sum.Enabled) textBox1.Text = calculator.Sum(temp).ToString();
                if (!Sub.Enabled) textBox1.Text = calculator.Substraction(temp).ToString();
                if (!Div.Enabled) textBox1.Text = calculator.Division(temp).ToString();
                if (!Mul.Enabled) textBox1.Text = calculator.Multiplication(temp).ToString();
                if (!Notch.Enabled) textBox1.Text = calculator.Notch().ToString(); 
                if (!Cos.Enabled) textBox1.Text = calculator.Cos().ToString();
                if (!OneDivX.Enabled) textBox1.Text = calculator.OneDivNumber().ToString();
                calculator.Memory = Convert.ToDouble(textBox1.Text);
                calculator.Clear();
                FreeButtons();
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.TextLength;
            }
            catch (Exception ex) { history.Text = ex.Message; }
        }
        /// <summary>
        /// Button "Div" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Div_Click(object sender, EventArgs e)
        {
            if (!CanPress()) return;
            OperationButtons();
            history.Text += " / ";
            Div.Enabled = false;
        }
        /// <summary>
        /// Button "Cos" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Cos_Click(object sender, EventArgs e)
        {
            if (!CanPress()) return;
            OperationButtons();
            history.Text = $"cos({calculator.Put_a})";
            Cos.Enabled = false;
            if (calculator.Put_a == 0 && !Cos.Enabled)
            {
                textBox1.Text = calculator.Cos().ToString();
                history.Text += " =";
                calculator.Memory = Convert.ToDouble(textBox1.Text);
                calculator.Clear();
                FreeButtons();
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.TextLength;
                return;
            }
            Equal_Click(this, EventArgs.Empty);
        }
        /// <summary>
        /// Button "OneDivX" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void OneDivX_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CanPress()) return;
                OperationButtons();
                OneDivX.Enabled = false;
                history.Text = $"1/{calculator.Put_a}";
                if (calculator.Put_a == 0 && !OneDivX.Enabled) textBox1.Text = calculator.OneDivNumber().ToString();
                Equal_Click(this, EventArgs.Empty);
            } catch(Exception ex) { history.Text = ex.Message; }
        }
        /// <summary>
        /// Button "Notch" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Notch_Click(object sender, EventArgs e)
        {
            if (!CanPress()) return;
            OperationButtons();
            Notch.Enabled = false;
            history.Text = $"{calculator.Put_a}^(1/2)";
            if (calculator.Put_a == 0 && !Notch.Enabled)
            {
                textBox1.Text = calculator.Notch().ToString();
                history.Text += " =";
                calculator.Memory = Convert.ToDouble(textBox1.Text);
                calculator.Clear();
                FreeButtons();
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.TextLength;
                return;
            }
            Equal_Click(this, EventArgs.Empty);
        }
        /// <summary>
        /// textBox1 keyPress event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> KeyPressEventArgs object. </param>
        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string s = textBox1.Text;
            int size = 0;
            if(e.KeyChar == 'b')
            {
                e.KeyChar = (char)'\b';
                size = 1;
            }
            if (Char.IsDigit(e.KeyChar)) s += e.KeyChar;
            double temp = default;
            if (s.Length > 1) temp = Convert.ToDouble(s);
            //Клавиша BACKSPACE
            if (e.KeyChar == (char)Keys.Back && textBox1.TextLength > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, size);
            else if (s == calculator.Memory.ToString() && calculator.Memory != 0)
            {
                history.Text = "";
                textBox1.Clear();
                textBox1.Focus();
                calculator.MemoryClear();
            }
            //Клавиша ,
            else if (e.KeyChar == ',')
            {
                if (textBox1.TextLength == 0 || temp == -1000000 || temp == 1000000)
                    e.KeyChar = (char)Keys.None;
                else
                {
                    int i = s.IndexOf(",", 0, s.Length);
                    if ((i != (-1)) || textBox1.Text[textBox1.TextLength - 1] == '-') e.KeyChar = (char)Keys.None;
                }
            }
            //Клавиша -
            else if (e.KeyChar == '-')
            {
                s = textBox1.Text;
                int i = s.Length;
                if (i > 0)
                {
                    e.KeyChar = (char)Keys.None;
                }
            }
            //Нажата клавиша с цифрой.
            else if (Char.IsDigit(e.KeyChar) & e.KeyChar != '.')
            {
                isEmptyString = true;
                if (textBox1.TextLength > 1)
                {
                    if (temp < -1000000 || temp > 1000000)
                        e.KeyChar = (char)Keys.None;
                }
                int index;
                if ((index = textBox1.Text.IndexOf(',')) > 0)
                {
                    if (textBox1.TextLength - index >= 3) e.KeyChar = (char)Keys.None;
                }
            }
            else
                e.KeyChar = (char)Keys.None;
        }
        /// <summary>
        /// Button "Mul" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Mul_Click(object sender, EventArgs e)
        {
            if (!CanPress()) return;
            OperationButtons();
            history.Text += " * ";
            Mul.Enabled = false;
        }
        /// <summary>
        /// Button "Sum" click event.
        /// </summary>
        /// <param name="sender"> Object. </param>
        /// <param name="e"> EventArgs object. </param>
        private void Sum_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 || (textBox1.TextLength == 1 && textBox1.Text == "-"))
            {
                textBox1.Text = "+";
                this.textBox1.Focus();
                this.textBox1.SelectionStart = textBox1.TextLength;
            }
            else
            {
                if (!CanPress()) return;
                OperationButtons();
                history.Text += " + ";
                Sum.Enabled = false;
            }
        }
        /// <summary>
        /// Method for proccesing symvols buttons.
        /// </summary>
        /// <param name="symvol"> Symvol of button. </param>
        private void SymvolsButtons(char symvol)
        {
            KeyPressEventArgs key = new KeyPressEventArgs(symvol);
            textBox1_KeyPress_1(this, key);
            if (key.KeyChar != '\b') textBox1.Text += key.KeyChar;
            this.textBox1.Focus();
            this.textBox1.SelectionStart = textBox1.TextLength;
        }
        /// <summary>
        /// Method for proccesing operations.
        /// </summary>
        private void OperationButtons()
        {
            if (textBox1.TextLength == 0 || (textBox1.TextLength == 1 && (textBox1.Text == "+" || textBox1.Text == "-"))) isEmptyString = false;
            if (CanPress())
            {
                calculator.Put_a = Convert.ToDouble(textBox1.Text);
                history.Text = calculator.Put_a.ToString();
                textBox1.Clear();
                textBox1.Focus();
            }
        }
        /// <summary>
        /// Checking buttons presses.
        /// </summary>
        /// <returns> false - buttons pressed, true - no buttons pressed</returns>
        private bool CanPress()
        {
            if (!Sum.Enabled) return false;
            if(!Sub.Enabled) return false;
            if(!Div.Enabled) return false;
            if(!Mul.Enabled) return false;
            if (!Notch.Enabled) return false;
            if (!Cos.Enabled) return false;
            if (!OneDivX.Enabled) return false;
            if (!isEmptyString) return false;
            return true;
        }
        /// <summary>
        /// Removing pressing from all operation buttons.
        /// </summary>
        private void FreeButtons()
        {
            Sum.Enabled = true;
            Sub.Enabled = true;
            Div.Enabled = true;
            Mul.Enabled = true;
            Notch.Enabled = true;
            Cos.Enabled = true;
            OneDivX.Enabled = true;
        }
    }
}
