using System;
using System.Numerics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator_update
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Initialization
        public bool InputChanged = false;
        public string operation = "";
        public bool minus_signed = false;
        public double fir_num = double.NaN;
        public double sec_num = double.NaN;
        public double memory = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TextBox_D.Focus();
        }
        private void TextBox_D_GotMouseCapture(object sender, MouseEventArgs e)
        {
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_D.Focus();
        }
        private void Word_length_limitation(int number)
        {
            if (number > 11)
            {
                for (int i = number; i > 11; i--)
                {
                    TextBox_D.Text = TextBox_D.Text.Remove(TextBox_D.Text.Length - 1);
                    TextBox_D.CaretIndex = TextBox_D.Text.Length;
                }
            }
        }
        #endregion

        #region TextBox change detection
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            char[] chr = TextBox_D.Text.ToCharArray();
            bool dote = false;
            for (int i = 0; i < TextBox_D.Text.Length; i++)
            {
                if (dote && chr[i] == 46)
                {
                    TextBox_D.Text = TextBox_D.Text.Remove(TextBox_D.Text.Length - 1);
                    TextBox_D.CaretIndex = TextBox_D.Text.Length;
                }
                else if (!dote && chr[i] == 46)
                {
                    dote = true;
                }
            }
            Word_length_limitation(TextBox_D.Text.Length);
            if (TextBox_D.Text.Length > 0)
            {
                if ((chr[TextBox_D.Text.Length - 1] >= 48 && chr[TextBox_D.Text.Length - 1] <= 57) || chr[TextBox_D.Text.Length - 1] == 46)
                {
                    if (TextBox_D.Text.Length == 2)
                    {
                        if (chr[0] == 48 && chr[1] == 48)
                        {
                            TextBox_D.Text = TextBox_D.Text.Remove(TextBox_D.Text.Length - 1);
                            TextBox_D.CaretIndex = TextBox_D.Text.Length;
                        }
                        else if (chr[0] == 48 && chr[1] > 48 && chr[1] <= 57)
                        {
                            TextBox_D.Text = TextBox_D.Text.Remove(0, 1);
                            TextBox_D.CaretIndex = TextBox_D.Text.Length;
                        }
                    }
                    
                    
                }
                else 
                {
                    if (chr[TextBox_D.Text.Length-1] == chr[0] && chr[0] == '-')
                    {
                        minus_signed = false;
                    }
                    TextBox_D.Text = TextBox_D.Text.Remove(TextBox_D.Text.Length-1); 
                    TextBox_D.CaretIndex = TextBox_D.Text.Length;
                }
            }
            else 
            {
                TextBox_D.Text = "0";
                TextBox_D.CaretIndex = TextBox_D.Text.Length;
            }
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
            TextBox_D.Focus();
        }
        #endregion

        #region Button press detection
        private void TextBox_D_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show($"{TextBox_D.CaretIndex}");

            if (e.Key == Key.D0 || e.Key == Key.NumPad0)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
                

            }
            else if (e.Key == Key.D1 || e.Key == Key.NumPad1)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
                
            }
            else if (e.Key == Key.D2 || e.Key == Key.NumPad2)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
                
            }
            else if (e.Key == Key.D3 || e.Key == Key.NumPad3)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.D4 || e.Key == Key.NumPad4)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.D5 || e.Key == Key.NumPad5)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.D6 || e.Key == Key.NumPad6)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.D7 || e.Key == Key.NumPad7)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.D8 || e.Key == Key.NumPad8)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.D9 || e.Key == Key.NumPad9)
            {
                if (!InputChanged)
                {
                    TextBox_D.Text = "";
                    if (operation == "")
                    {
                        fir_num = double.NaN;
                    }
                }
                InputChanged = true;
            }
            else if (e.Key == Key.Add)
            {
                Add_Button_Click(sender, null);
            }
            else if (e.Key == Key.Subtract)
            {
                Sub_Button_Click(sender, null);
            }
            else if (e.Key == Key.Multiply)
            {
                Mult_Button_Click(sender, null);
            }
            else if (e.Key == Key.Divide)
            {
                Divide_clicked(sender, null);
            }
            else if (e.Key == Key.Enter)
            {
                Equal_Button_Click(sender, null);
            }
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        private void TextBox_D_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        #endregion

        #region Buttons
        #region Numerical Buttons

        private void Zero_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "0";
            InputChanged = true;
        }

        private void One_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "1";
            InputChanged = true;
        }

        private void Two_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "2";
            InputChanged = true;
        }

        private void Three_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "3";
            InputChanged = true;
        }

        private void Four_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "4";
            InputChanged = true;
        }

        private void Five_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "5";
            InputChanged = true;
        }

        private void Six_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "6";
            InputChanged = true;
        }

        private void Seven_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "7";
            InputChanged = true;
        }

        private void Eight_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "8";
            InputChanged = true;
        }

        private void Nine_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!InputChanged)
            {
                TextBox_D.Text = "";
            }
            TextBox_D.Text += "9";
            InputChanged = true;
        }

        #endregion

        #region Operational Buttons
        #region Divide Button
        private void Divide_clicked(object sender, RoutedEventArgs e)
        {
            Calculations("/");
            TextBox_D.Focus();
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        #endregion

        #region Multiply Button
        private void Mult_Button_Click(object sender, RoutedEventArgs e)
        {
            Calculations("*");
            TextBox_D.Focus();
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        #endregion

        #region Add Button
        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            Calculations("+");
            TextBox_D.Focus();
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        #endregion

        #region Subtract Button
        private void Sub_Button_Click(object sender, RoutedEventArgs e)
        {
            Calculations("-");
            TextBox_D.Focus();
        }
        #endregion

        #region Persent Button
        private void Percent_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.IsNaN(fir_num))
            {
                if (InputChanged)
                {
                    sec_num = double.Parse(TextBox_D.Text);

                    TextBox_D.Text = ((sec_num * fir_num) / 100).ToString();
                }
            }
            else
            {
                TextBox_D.Text = "";
            }

        }
        #endregion

        #region One over X button
        private void One_over_X_Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox_D.Text))
            {
                sec_num = double.Parse(TextBox_D.Text);

                sec_num = 1 / sec_num;

                sec_num = Math.Round(sec_num, 9);

                TextBox_D.Text = sec_num.ToString();
                sec_num = double.NaN;
            }
            else
            {
                TextBox_D.Text = "";
            }
        }
        #endregion

        #region Square Button
        private void SQVR_Button_Click(object sender, RoutedEventArgs e)
        {
            sec_num = double.Parse(TextBox_D.Text);
            sec_num = sec_num * sec_num;
            TextBox_D.Text = sec_num.ToString();
            sec_num = double.NaN;
        }
        #endregion

        #region Square Root
        private void SQRT_Button_Click(object sender, RoutedEventArgs e)
        {
            sec_num = double.Parse(TextBox_D.Text);
            if (sec_num >= 0)
            {
                sec_num = Math.Sqrt(sec_num);
                sec_num = Math.Round(sec_num, 9);
                TextBox_D.Text = sec_num.ToString();
                sec_num = double.NaN;
            }
            MessageBox.Show("For negative number cant be found square root");
        }
        #endregion

        #endregion

        #region Deletion Buttons
        #region Back Button
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox_D.Text = TextBox_D.Text.Remove(TextBox_D.Text.Length - 1);
            TextBox_D.CaretIndex = TextBox_D.Text.Length;
        }
        #endregion

        #region C button
        private void C_Button_Click(object sender, RoutedEventArgs e)
        {
            fir_num = double.NaN;
            sec_num = double.NaN;
            operation = "";
            InputChanged = false;
            minus_signed = false;
            TextBox_D.Text = "0";
        }
        #endregion

        #region CE button
        private void CE_Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox_D.Text = "";
        }
        #endregion
        #endregion

        #region Memory Buttons
        #region MC Button
        private void MC_Button_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
        }
        #endregion
        #region MR Button
        private void MR_Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox_D.Text = memory.ToString();
            if (minus_signed)
            {
                minus_signed = false;
            }
            else if (InputChanged)
            {
                InputChanged = false;
            }

        }
        #endregion
        #region M+ Button
        private void MPlus_Button_Click(object sender, RoutedEventArgs e)
        {
            memory = memory + double.Parse(TextBox_D.Text);
        }
        #endregion
        #region M- button
        private void MMinus_Button_Click(object sender, RoutedEventArgs e)
        {
            memory = memory - double.Parse(TextBox_D.Text);
        }
        #endregion
        #region MS Button
        private void MS_Button_Click(object sender, RoutedEventArgs e)
        {
            memory = double.Parse(TextBox_D.Text);
        }
        #endregion
        #endregion

        #endregion

        #region Operation area
        #region (.) & (=) & (+/-)
        // Dote
        private void Dote_Button_Click(object sender, RoutedEventArgs e)
        {

            TextBox_D.Text += ".";
        }

        // +/- button
        private void Opr_Button_Click(object sender, RoutedEventArgs e)
        {
            char[] chr = TextBox_D.Text.ToCharArray();
            string newStr = "";
            if (minus_signed)
            {
                TextBox_D.Text = TextBox_D.Text.Remove(0, 1);
                TextBox_D.CaretIndex = TextBox_D.Text.Length;
                minus_signed = false;
            }
            else
            {
                newStr = "-";
                minus_signed = true;
                for (int i = 0; TextBox_D.Text.Length - 1 >= i; i++)
                {
                    newStr += chr[i].ToString();
                }
                TextBox_D.Text = newStr;
                TextBox_D.CaretIndex = TextBox_D.Text.Length;
            }
            TextBox_D.Focus();
        }

        // Equal button
        private void Equal_Button_Click(object sender, RoutedEventArgs e)
        {

            if (operation != "")
            {
                if (InputChanged)
                {
                    if (!double.IsNaN(fir_num))
                    {
                        sec_num = double.Parse(TextBox_D.Text);

                        if (operation == "+")
                        {
                            fir_num += sec_num;
                        }
                        else if (operation == "-")
                        {
                            fir_num -= sec_num;
                        }
                        else if (operation == "*")
                        {
                            fir_num *= sec_num;
                        }
                        else if (operation == "/")
                        {
                            fir_num /= sec_num;
                        }

                        TextBox_D.Text = fir_num.ToString();
                        InputChanged = false;
                        operation = "";
                    }
                }
            }
        }
        #endregion

        #region Calculation area
        private void Calculations(string Func_Operation)
        {
            if (TextBox_D.Text == "0" && !InputChanged){}
            else
            {
                if (InputChanged)
                {
                    if (double.IsNaN(fir_num))
                    {
                        operation = Func_Operation;
                        fir_num = double.Parse(TextBox_D.Text);
                    }
                    else if(operation != "")
                    {
                        sec_num = double.Parse(TextBox_D.Text);

                        if (operation == "+")
                        {
                            fir_num += sec_num;
                        }
                        else if (operation == "-")
                        {

                            fir_num -= sec_num;
                        }
                        else if (operation == "*")
                        {
                            fir_num *= sec_num;
                        }
                        else if (operation == "/")
                        {
                            fir_num /= sec_num;
                        }

                        TextBox_D.Text = fir_num.ToString();

                        operation = Func_Operation;
                    }
                    //InputChanged = false;
                }
                else
                {
                    operation = Func_Operation;
                }
            }
            InputChanged = false;
        }
        #endregion
        #endregion
    }
}
