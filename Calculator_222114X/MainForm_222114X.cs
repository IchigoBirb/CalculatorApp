using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.CodeDom.Compiler;
using System.Xml.Schema;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Media;
using System.Speech.Synthesis;

namespace Calculator_222114X
{
    public partial class MainForm_222114X : Form
    {
        //-------------INIT variables--------------
        SpeechSynthesizer syn = new SpeechSynthesizer();
        bool flagOpPressed = false,Radianmode=false, shifted = false;
        string opr = "", Calculate = "", Binarystring="";
        double operand = 0;
        int index = 0, number = 0, CounterH=-1,width = 49,height=55;
        double Ans = 0.00,Holding = 0.00,radians = 0.00,result= 0.00,log_e_b=0.00,bits=0.00;
        List<string> strings = new List<string>() { };
        List<string> operatosrs = new List<string>() { };
        List<int> indexlist = new List<int>() { };


        public MainForm_222114X()
        {   
            InitializeComponent();
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
            EquationTxtbox.Select();
        }

        private void MainForm_222114X_KeyPress(object sender, KeyPressEventArgs e)
        {
            //--------------Performs click corresponding to the button pressed from the user's keyboard-------------------
            switch (e.KeyChar.ToString())
            {
                case "c":
                    btnCE.PerformClick();
                    break;
                case "0":
                    btn0.PerformClick();
                    break;
                case "1":
                    btn1.PerformClick();
                    break;
                case "2":
                    btn2.PerformClick();
                    break;
                case "3":
                    btn3.PerformClick();
                    break;
                case "4":
                    btn4.PerformClick();
                    break;
                case "5":
                    btn5.PerformClick();
                    break;
                case "6":
                    btn6.PerformClick();
                    break;
                case "7":
                    btn7.PerformClick();
                    break;
                case "8":
                    btn8.PerformClick();
                    break;
                case "9":
                    btn9.PerformClick();
                    break;
                case "+":
                    btnAdd.PerformClick();
                    break;
                case "-":
                    btnMinus.PerformClick();
                    break;
                case "*":
                    btnMult.PerformClick();
                    break;
                case "/":
                    btnDiv.PerformClick();
                    break;
                case "%":
                    btnMod.PerformClick();
                    break;
                case "=":
                case "\r":
                    btnEqu.PerformClick();
                    break;
                case ".":
                    deci.PerformClick();
                    break;
                case "\b":
                    back.PerformClick();
                    break;
            }

        }

        private void MainForm_222114X_Load(object sender, EventArgs e)
        {
            //-------------INIT checkbox states--------------
            //Notif.CheckState = CheckState.Checked; //Turned off 
            Color.CheckState = CheckState.Checked;
            //Sound.CheckState = CheckState.Checked; //Turned off 
        }

        private void lblID_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
            Clipboard.SetText(attribute.Value.ToString());
        }

        //-------------Reset calculator--------------
        private void btnC_Click(object sender, EventArgs e)
        {
            CounterH = -1;
            opr = "";
            operand = 0;
            flagOpPressed = false;
            EquationTxtbox.Text = "0";
            eqLBL.Text = "Type an equation";
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
            EquationTxtbox.Select();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            EquationTxtbox.Select();
        }

        //-------------Hides scientific stuff with a panel if STD mode--------------
        private void button2_Click_1(object sender, EventArgs e)
        {
             if (STDSCI.Text == "Scientific")
            {
                width = 49;
                height = 55;
                //Make scientific buttons 0 size //Avoided using panel because it messes with new button ui
                btnLg.Size = new Size(0, 0);
                btnLn.Size = new Size(0, 0);
                btnCos.Size = new Size(0, 0);
                btnSin.Size = new Size(0, 0);
                btnTan.Size = new Size(0, 0);

                btnMod.Size = new Size(0, 0);
                btnSqrt.Size = new Size(0, 0);
                btnBinary.Size = new Size(0, 0);
                btnPower.Size = new Size(0, 0);
                xovery.Size = new Size(0, 0);

                STDSCI.Text = "Standard";
                STD.Text = "SCI";

                btnAns.Size = new Size(width, height);
                btnAns.Top -= 20;
                btn0.Size = new Size(width, height);
                btn0.Top -= 20;
                btnPlusMinus.Size = new Size(width, height);
                btnPlusMinus.Top -= 20;
                btnCE.Size = new Size(width, height);
                btnCE.Top -= 20;
                btnEqu.Size = new Size(width, height);
                btnEqu.Top -= 20;

                btn1.Size = new Size(width, height);
                btn1.Top -= 40;
                btn2.Size = new Size(width, height);
                btn2.Top -= 40;
                btn3.Size = new Size(width, height);
                btn3.Top -= 40;
                deci.Size = new Size(width, height);
                deci.Top -= 40;
                back.Size = new Size(width, height);
                back.Top -= 40;

                btn4.Size = new Size(width, height);
                btn4.Top -= 60;;
                btn5.Size = new Size(width, height);
                btn5.Top -= 60; ;
                btn6.Size = new Size(width, height);
                btn6.Top -= 60; ;
                btnMult.Size = new Size(width, height);
                btnMult.Top -= 60; ;
                btnDiv.Size = new Size(width, height);
                btnDiv.Top -= 60; ;

                btn7.Size = new Size(width, height);
                btn7.Top -= 80; ;
                btn8.Size = new Size(width, height);
                btn8.Top -= 80; ;
                btn9.Size = new Size(width, height);
                btn9.Top -= 80; ;
                btnAdd.Size = new Size(width, height);
                btnAdd.Top -= 80; ;
                btnMinus.Size = new Size(width, height);
                btnMinus.Top -= 80; ;
            }
            else if (STDSCI.Text == "Standard")
            {
                width = 55;
                height =40;
                STDSCI.Text = "Scientific";
                STD.Text = "STD";

                btnLg.Size = new Size(width, height);
                btnLn.Size = new Size(width, height);
                btnCos.Size = new Size(width, height);
                btnSin.Size = new Size(width, height);
                btnTan.Size = new Size(width, height);

                btnMod.Size = new Size(width, height);
                btnSqrt.Size = new Size(width, height);
                btnBinary.Size = new Size(width, height);
                btnPower.Size = new Size(width, height);
                xovery.Size = new Size(width, height);

                btnAns.Size = new Size(width, height);
                btnAns.Top += 20;
                btn0.Size = new Size(width, height);
                btn0.Top += 20;
                btnPlusMinus.Size = new Size(width, height);
                btnPlusMinus.Top += 20;
                btnCE.Size = new Size(width, height);
                btnCE.Top += 20;
                btnEqu.Size = new Size(width, height);
                btnEqu.Top += 20;

                btn1.Size = new Size(width, height);
                btn1.Top += 40;
                btn2.Size = new Size(width, height);
                btn2.Top += 40;
                btn3.Size = new Size(width, height);
                btn3.Top += 40;
                deci.Size = new Size(width, height);
                deci.Top += 40;
                back.Size = new Size(width, height);
                back.Top += 40;

                btn4.Size = new Size(width, height);
                btn4.Top += 60; ;
                btn5.Size = new Size(width, height);
                btn5.Top += 60; ;
                btn6.Size = new Size(width, height);
                btn6.Top += 60; ;
                btnMult.Size = new Size(width, height);
                btnMult.Top += 60; ;
                btnDiv.Size = new Size(width, height);
                btnDiv.Top += 60; ;

                btn7.Size = new Size(width, height);
                btn7.Top += 80; ;
                btn8.Size = new Size(width, height);
                btn8.Top += 80; ;
                btn9.Size = new Size(width, height);
                btn9.Top += 80; ;
                btnAdd.Size = new Size(width, height);
                btnAdd.Top += 80; ;
                btnMinus.Size = new Size(width, height);
                btnMinus.Top += 80; ;
            }
            EquationTxtbox.Select();
        }

        //-------------Numpad and decimal [0-9,.]--------------
        private void NumPad(object sender, EventArgs e)
        {
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;

            //-------------Gets which button was pressed--------------
            Button btn = (Button)sender;
            string ButtonClicked = btn.Text;
            string Inputs = EquationTxtbox.Text;
            if (Color.CheckState == CheckState.Checked)
            {
                btn.BackColor = System.Drawing.Color.Green;
            }
            if (Sound.CheckState == CheckState.Checked)
            {
                SystemSounds.Beep.Play();
                syn.Speak(ButtonClicked);
            }
            //clear display if operator was pressed already
            if (flagOpPressed == true)
            {
                Inputs = "";
                flagOpPressed = false;
            }
            //clear display of equation textbox if new/contains stuff that may break it
            if (eqLBL.Text == "Type an equation" || eqLBL.Text.Contains("C") || eqLBL.Text.Contains("l") || eqLBL.Text.Contains("n") || eqLBL.Text.Contains("√"))
            {
                eqLBL.Text = "";
            }
            //-------------Displays which button was pressed in both textbox--------------
            switch (ButtonClicked)
            {
                case ".":
                    if (!Inputs.Contains('.'))
                    {
                        Inputs += '.';
                        eqLBL.Text += ".";
                    }
                    break;
                default:
                    if (EquationTxtbox.Text == "0")
                    {
                        Inputs = "";
                        eqLBL.Text = "";
                    }
                    Inputs += ButtonClicked;
                    eqLBL.Text += ButtonClicked;


                    break;
            }
            EquationTxtbox.Text = Inputs;
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
            EquationTxtbox.Select();
        }

        private void TB_Keydown(object sender, KeyEventArgs e)
        {
            //------Backup code incase hard input fails-------
            if (e.KeyCode == Keys.Enter)
                btnEqu.PerformClick();
            else if (e.KeyCode == Keys.C)
            {
                btnC.PerformClick();
            }
        }

        private void SHIFT_Click(object sender, EventArgs e)
        {
            //Changes ui for the calculator to its respective button when shift is pressed
            if(shifted == false)
            {
                btnCos.Text = "Cos⁻¹";
                btnSin.Text = "Sin⁻¹";
                btnTan.Text = "Tan⁻¹";
                btnLg.Text = "₁₀ˣ";
                btnLg.Font = new Font("Microsoft Sans Serif", 15);
                btnLn.Text = "ℯˣ";
                btnLn.Font = new Font("Microsoft Sans Serif", 15);
                shifted = true;
            }
            else if (shifted == true)
            {
                btnCos.Text = "cos θ";
                btnSin.Text = "sin θ";
                btnTan.Text = "tan θ";
                btnLg.Text = "x Log⏨";
                btnLg.Font = new Font("Microsoft Sans Serif", 9);
                btnLn.Text = "ln x";
                btnLn.Font = new Font("Microsoft Sans Serif", 12);
                shifted = false;
                
            }
            EquationTxtbox.Select();
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;


            if (Notif.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Implement Displayed Result announcement when [EQUAL] key is hit", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (Color.CheckState == CheckState.Checked)
            {
                btnEqu.BackColor = System.Drawing.Color.Green;
            }
            if (Sound.CheckState == CheckState.Checked)
            {
                SystemSounds.Beep.Play();
                syn.Speak("equals to");
            }
            //-------------Returns value if no operators--------------
            if (EquationTxtbox.Text == eqLBL.Text)
            {
                Ans = Double.Parse(EquationTxtbox.Text);
                Console.WriteLine(Ans);
                EquationTxtbox.Text = Ans.ToString();
                eqLBL.Text = Ans.ToString();
                Holding = Double.Parse(Ans.ToString());
            }
            //-------------Checks if equation was typed using buttons or pasted--------------
            bool success = int.TryParse(EquationTxtbox.Text, out number);
            if (success)
            {
                Calculate = eqLBL.Text;
                //Equation typed using buttons get from equation label
            }
            else
            {
                Calculate = EquationTxtbox.Text;
                EquationTxtbox.Text = "0";
                //Equation pasted get from equation textbox
            }
            try
            {
                if (eqLBL.Text == "Type an equation" || EquationTxtbox.Text != eqLBL.Text)
                {
                    CounterH = -1;
                    //Splits the entire "Calculate" into numbers and their operators from left to right using regex
                    string[] substrings = Regex.Split(Calculate, @"([%*()^√/+-])");
                    foreach (string match in substrings)
                    {
                        String split = String.Format("'{0}'", match);//saves the data as a string to be appended to a list
                        split = split.Replace(" ", "");
                        String FirstOne = split.Remove((split.Length - 1), 1); //Fixed double digits and decimal
                                                                               // DO NOT REMOVE the remove IT IS VERY IMPORTANT 
                        String FirstTwo = FirstOne.Remove(0, 1);
                        //Console.WriteLine(FirstTwo); // DEBUGGING
                        strings.Add(FirstTwo);//appends the data to a list
                    }
                    while (strings.Count != 1)
                    {
                        CounterH += 1;
                        //Console.WriteLine(CounterH); //DEBUGGING
                        if (strings[CounterH] == "%")//checks operator
                        {
                            Ans = Double.Parse(strings[CounterH - 1]) % Double.Parse(strings[CounterH + 1]);
                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Ans, 2, MidpointRounding.AwayFromZero);
                                Ans = Double.Parse(String.Format("{0:0.00}", Ans));
                            }
                            EquationTxtbox.Text = Ans.ToString();
                            Console.WriteLine(Ans);
                            index = (CounterH - 1);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.Insert(index, Ans.ToString());
                            CounterH = -1;
                        }
                        else if (strings[CounterH] == "^")//checks operator
                        {
                            Ans = Math.Pow(Double.Parse(strings[CounterH - 1]), Double.Parse(strings[CounterH + 1]));
                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Ans, 2, MidpointRounding.AwayFromZero);
                                Ans = Double.Parse(String.Format("{0:0.00}", Ans));
                            }
                            EquationTxtbox.Text = Ans.ToString();
                            Console.WriteLine(Ans);
                            index = (CounterH - 1);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.Insert(index, Ans.ToString());
                            CounterH = -1;
                        }
                        else if (strings[CounterH] == "/")//checks operator
                        {
                            Ans = Double.Parse(strings[CounterH - 1]) / Double.Parse(strings[CounterH + 1]);
                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Ans, 2, MidpointRounding.AwayFromZero);
                                Ans = Double.Parse(String.Format("{0:0.00}", Ans));
                            }
                            EquationTxtbox.Text = Ans.ToString();
                            Console.WriteLine(Ans);
                            index = (CounterH - 1);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.Insert(index, Ans.ToString());
                            CounterH = -1;
                        }
                        else if (strings[CounterH] == "*" && strings.Contains("/") == false)//checks operator
                        {
                            Ans = Double.Parse(strings[CounterH - 1]) * Double.Parse(strings[CounterH + 1]);
                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Ans, 2, MidpointRounding.AwayFromZero);
                                Ans = Double.Parse(String.Format("{0:0.00}", Ans));
                            }
                            EquationTxtbox.Text = Ans.ToString();
                            Console.WriteLine(Ans);
                            index = (CounterH - 1);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.Insert(index, Ans.ToString());
                            CounterH = -1;
                        }
                        else if (strings[CounterH] == "+" && strings.Contains("/") == false && strings.Contains("*") == false)//checks operator
                        {
                            Ans = Double.Parse(strings[CounterH - 1]) + Double.Parse(strings[CounterH + 1]);
                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Ans, 2, MidpointRounding.AwayFromZero);
                                Ans = Double.Parse(String.Format("{0:0.00}", Ans));
                            }
                            EquationTxtbox.Text = Ans.ToString();
                            Console.WriteLine(Ans);
                            index = (CounterH - 1);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.Insert(index, Ans.ToString());
                            CounterH = -1;
                        }
                        else if (strings[CounterH] == "-" && strings.Contains("/") == false && strings.Contains("*") == false)//checks operator
                        {
                            Ans = Double.Parse(strings[CounterH - 1]) - Double.Parse(strings[CounterH + 1]);
                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Ans, 2, MidpointRounding.AwayFromZero);
                                Ans = Double.Parse(String.Format("{0:0.00}", Ans));
                            }
                            EquationTxtbox.Text = Ans.ToString();
                            Console.WriteLine(Ans);
                            index = (CounterH - 1);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.RemoveAt(index);
                            strings.Insert(index, Ans.ToString());
                            CounterH = -1;
                        }
                        else
                        {
                            index += 1;
                        }
                        Holding = Ans;
                        
                    }
                    syn.Speak(Holding.ToString());
                    flagOpPressed = false;
                    CounterH = -1;
                    strings.Clear();
                    EquationTxtbox.Select();
                }
            }
            catch
            {
                syn.Speak("Cannot convert due to wrong format typed in");
                MessageBox.Show("Cannot convert due to wrong format typed in", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        //-------------Auto copy to clipboard--------------
        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(EquationTxtbox.Text);
            EquationTxtbox.Select();
        }
        //-------------Radian Degree mode switch UI--------------
        private void Radian_Click(object sender, EventArgs e)
        {
            if (Mode.Text == "Radian")
            {
                syn.Speak("Radian mode");
                Radianmode = true;
                Radian.Text = "RAD";
                Mode.Text = "Degree";
            }
            else
            {
                syn.Speak("Degree mode");
                Radianmode = false;
                Radian.Text = "DEG";
                Mode.Text = "Radian";
            }
            EquationTxtbox.Select();
        }

        //-------------Clear Entry--------------
        private void btnCE_Click(object sender, EventArgs e)
        {
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;
            EquationTxtbox.Text = "0";
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
            EquationTxtbox.Select();
            syn.Speak("Cleared entry");
        }

        //-------------Checks which operator was pressed--------------
        private void operatorClick(object sender, EventArgs e)
        {
            if (eqLBL.Text != "Type an equation")
            {
                btn0.BackColor = System.Drawing.Color.Black;
                btn1.BackColor = System.Drawing.Color.Black;
                btn2.BackColor = System.Drawing.Color.Black;
                btn3.BackColor = System.Drawing.Color.Black;
                btn4.BackColor = System.Drawing.Color.Black;
                btn5.BackColor = System.Drawing.Color.Black;
                btn6.BackColor = System.Drawing.Color.Black;
                btn7.BackColor = System.Drawing.Color.Black;
                btn8.BackColor = System.Drawing.Color.Black;
                btn9.BackColor = System.Drawing.Color.Black;

                btnMod.BackColor = System.Drawing.Color.Black;
                btnSqrt.BackColor = System.Drawing.Color.Black;
                btnBinary.BackColor = System.Drawing.Color.Black;
                btnPower.BackColor = System.Drawing.Color.Black;
                xovery.BackColor = System.Drawing.Color.Black;

                btnAns.BackColor = System.Drawing.Color.Black;
                btnPlusMinus.BackColor = System.Drawing.Color.Black;
                btnCE.BackColor = System.Drawing.Color.DarkOrange;
                btnEqu.BackColor = System.Drawing.Color.White;

                btnLg.BackColor = System.Drawing.Color.Black;
                btnLn.BackColor = System.Drawing.Color.Black;
                btnSin.BackColor = System.Drawing.Color.Black;
                btnCos.BackColor = System.Drawing.Color.Black;
                btnTan.BackColor = System.Drawing.Color.Black;

                btnAdd.BackColor = System.Drawing.Color.Black;
                btnMinus.BackColor = System.Drawing.Color.Black;
                btnMult.BackColor = System.Drawing.Color.Black;
                btnDiv.BackColor = System.Drawing.Color.Black;
                deci.BackColor = System.Drawing.Color.Black;
                back.BackColor = System.Drawing.Color.Black;
                //-------------if operator is the first clicked--------------
                if (eqLBL.Text == "Type an equation")
                {
                    eqLBL.Text = "0";
                }
                if (flagOpPressed != true)
                {

                    // get the operand value
                    operand = Double.Parse(EquationTxtbox.Text);
                    Button btn = (Button)sender;
                    opr = btn.Tag.ToString();
                    if (Color.CheckState == CheckState.Checked)
                    {
                        btn.BackColor = System.Drawing.Color.Green;
                    }
                    if (Sound.CheckState == CheckState.Checked)
                    {
                        SystemSounds.Beep.Play();
                        syn.Speak(opr);
                    }
                    switch (opr)
                    {
                        case "Add":
                            eqLBL.Text += "+";
                            break;
                        case "Minus":
                            eqLBL.Text += "-";
                            break;
                        case "Mult":
                            eqLBL.Text += "*";
                            break;
                        case "Div":
                            eqLBL.Text += "/";
                            break;
                        case "Mod":
                            eqLBL.Text += "%";
                            break;
                        case "Power":
                            eqLBL.Text += "^";
                            break;
                        default:
                            break;
                    }
                    flagOpPressed = true;
                    EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
                    EquationTxtbox.Select();
                }
                else
                {
                    syn.Speak("Can not have 2 operators in a row");
                    MessageBox.Show("Can not have 2 operators in a row", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //-------------Previous Ans--------------
        private void button2_Click(object sender, EventArgs e)
        {
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;
            if (Color.CheckState == CheckState.Checked)
            {
                btnAns.BackColor = System.Drawing.Color.Green;
            }
            if (Sound.CheckState == CheckState.Checked)
            {
                SystemSounds.Beep.Play();
            }
            if (eqLBL.Text == "Type an equation")
            {
                eqLBL.Text = "";
            }
            eqLBL.Text += Holding.ToString();
            EquationTxtbox.Text = Holding.ToString();
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
            EquationTxtbox.Select();
        }

        //-------------Swaps sign of current entry/ans--------------
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;
            if (Color.CheckState == CheckState.Checked)
            {
                btnPlusMinus.BackColor = System.Drawing.Color.Green;
            }
            if (Sound.CheckState == CheckState.Checked)
            {
                SystemSounds.Beep.Play();
            }
            if (EquationTxtbox.Text == "0")
            {
                EquationTxtbox.Text = (Holding * -1).ToString();
            }
            else
            {
                //-------------Prevents user typing an equation then swapping signs--------------
                try
                {
                    Double temporary = Convert.ToDouble(EquationTxtbox.Text);
                    EquationTxtbox.Text = (temporary * -1).ToString();
                }
                catch//Only happens if user pastes in formula and tries to convert
                {
                    MessageBox.Show("Cannot convert due to an operator's presence", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
            EquationTxtbox.Select();


        }

        private void back_Click(object sender, EventArgs e)
        {
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;
            if (Color.CheckState == CheckState.Checked)
            {
                back.BackColor = System.Drawing.Color.Green;
            }
            if (Sound.CheckState == CheckState.Checked)
            {
                SystemSounds.Beep.Play();
            }
            Holding = Double.Parse(EquationTxtbox.Text);
            //-------------Removes display then equation--------------
            if (flagOpPressed = true && eqLBL.Text != "" && eqLBL.Text != "Type an equation")
            {
                eqLBL.Text = eqLBL.Text.Remove(eqLBL.Text.Length - 1, 1);
                flagOpPressed = false;
            }
            else if (eqLBL.Text == "" || eqLBL.Text == "Type an equation")
            {
                opr = "";
                operand = 0;
                flagOpPressed = false;
                EquationTxtbox.Text = "0";
                eqLBL.Text = "Type an equation";
            }
            else
            {
                try
                {
                    EquationTxtbox.Text = EquationTxtbox.Text.Remove(EquationTxtbox.Text.Length - 1, 1);
                    eqLBL.Text = eqLBL.Text.Remove(eqLBL.Text.Length - 1, 1);
                }
                catch (Exception)
                {
                    syn.Speak("Cannot backspace anymore");
                    MessageBox.Show("Cannot backspace anymore", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
        }

        private void singleEntryClick(object sender, EventArgs e)
        {
            btn0.BackColor = System.Drawing.Color.Black;
            btn1.BackColor = System.Drawing.Color.Black;
            btn2.BackColor = System.Drawing.Color.Black;
            btn3.BackColor = System.Drawing.Color.Black;
            btn4.BackColor = System.Drawing.Color.Black;
            btn5.BackColor = System.Drawing.Color.Black;
            btn6.BackColor = System.Drawing.Color.Black;
            btn7.BackColor = System.Drawing.Color.Black;
            btn8.BackColor = System.Drawing.Color.Black;
            btn9.BackColor = System.Drawing.Color.Black;

            btnMod.BackColor = System.Drawing.Color.Black;
            btnSqrt.BackColor = System.Drawing.Color.Black;
            btnBinary.BackColor = System.Drawing.Color.Black;
            btnPower.BackColor = System.Drawing.Color.Black;
            xovery.BackColor = System.Drawing.Color.Black;

            btnAns.BackColor = System.Drawing.Color.Black;
            btnPlusMinus.BackColor = System.Drawing.Color.Black;
            btnCE.BackColor = System.Drawing.Color.DarkOrange;
            btnEqu.BackColor = System.Drawing.Color.White;

            btnLg.BackColor = System.Drawing.Color.Black;
            btnLn.BackColor = System.Drawing.Color.Black;
            btnSin.BackColor = System.Drawing.Color.Black;
            btnCos.BackColor = System.Drawing.Color.Black;
            btnTan.BackColor = System.Drawing.Color.Black;

            btnAdd.BackColor = System.Drawing.Color.Black;
            btnMinus.BackColor = System.Drawing.Color.Black;
            btnMult.BackColor = System.Drawing.Color.Black;
            btnDiv.BackColor = System.Drawing.Color.Black;
            deci.BackColor = System.Drawing.Color.Black;
            back.BackColor = System.Drawing.Color.Black;
            if (EquationTxtbox.Text != "0")
                {
                // get the operand value
                operand = Double.Parse(EquationTxtbox.Text);
                Button btn = (Button)sender;
                opr = btn.Tag.ToString();
                if (Color.CheckState == CheckState.Checked)
                {
                    btn.BackColor = System.Drawing.Color.Green;
                }
                if (Sound.CheckState == CheckState.Checked)
                {
                    SystemSounds.Beep.Play();
                }
                if (eqLBL.Text == "Type an equation")
                {
                    eqLBL.Text = "";
                }
                if (flagOpPressed != true)
                {
                    switch (opr)
                    {
                        case "Sqrt":
                            eqLBL.Text = "√";
                            eqLBL.Text += EquationTxtbox.Text;
                            EquationTxtbox.Text = (Math.Sqrt(Double.Parse(EquationTxtbox.Text))).ToString();
                            Holding = Math.Sqrt(Double.Parse(EquationTxtbox.Text));

                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                            }
                            break;
                        case "Binary":
                            EquationTxtbox.Text = Double.Parse(EquationTxtbox.Text).ToString();
                            if (Double.Parse(EquationTxtbox.Text) >  0)
                            {
                                Ans = 0;
                                bits = EquationTxtbox.Text.Length;
                                Binarystring = EquationTxtbox.Text;
                                //Console.WriteLine(Binarystring); 
                                for (int i = 0; i < bits; i++)
                                {
                                    if (Binarystring[i] == '1' || Binarystring[i] == '0')
                                    {

                                        Ans += ((Double.Parse(Binarystring[i].ToString()) * Math.Pow(2, bits - i))/2);
                                        Holding = Ans;
                                        //Console.WriteLine(Ans);
                                        eqLBL.Text = "Type an equation";
                                    }
                                    else if (Binarystring[i] != '1' || Binarystring[i] != '0')
                                    {
                                        MessageBox.Show("Contains non-Binary numbers", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        eqLBL.Text = "Type an equation";
                                    }

                                }
                                EquationTxtbox.Text = Ans.ToString();

                            }
                            else if (Double.Parse(EquationTxtbox.Text) > 2)
                            {
                                Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                            }

                            Holding = Math.Sqrt(Double.Parse(EquationTxtbox.Text));

                            if (AutoRound.CheckState == CheckState.Checked)
                            {
                                Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                            }
                            break;
                        case "Lg":
                            if (shifted == false)
                            {
                                eqLBL.Text += "log⏨";
                                EquationTxtbox.Text = (Math.Log10(Double.Parse(EquationTxtbox.Text))).ToString();
                                Holding = Math.Log10(Double.Parse(EquationTxtbox.Text));

                                if (AutoRound.CheckState == CheckState.Checked)
                                {
                                    Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                    EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                }
                            }
                            else if (shifted == true)
                            {
                                eqLBL.Text = "10^";
                                eqLBL.Text += EquationTxtbox.Text;
                            }
                            break;
                        case "Ln":
                            if (shifted == false)
                            {
                                eqLBL.Text = "ln";
                                eqLBL.Text += EquationTxtbox.Text;
                                log_e_b = Math.Log10(Double.Parse(EquationTxtbox.Text)) / Math.Log10(2.71828182846);
                                EquationTxtbox.Text = log_e_b.ToString();
                                Holding = log_e_b;

                                if (AutoRound.CheckState == CheckState.Checked)
                                {
                                    Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                    EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                }
                            }
                            else if (shifted == true)
                            {
                                eqLBL.Text = "e^";
                                eqLBL.Text += EquationTxtbox.Text;
                                EquationTxtbox.Text = (Math.Exp(Double.Parse(EquationTxtbox.Text))).ToString();
                                Holding = Math.Exp(Double.Parse(EquationTxtbox.Text));

                                if (AutoRound.CheckState == CheckState.Checked)
                                {
                                    Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                    EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                }
                            }
                            break;

                            
                        case "Cos":

                            if (shifted == false)
                            {
                                eqLBL.Text = "Cos";
                                eqLBL.Text += EquationTxtbox.Text;
                                if (Radianmode == true)
                                {

                                    radians = (Double.Parse(EquationTxtbox.Text)) * (Math.PI / 180);
                                    result = Math.Cos(radians);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                                else
                                {
                                    result = Math.Cos(Double.Parse(EquationTxtbox.Text));
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                            }
                            else
                            {
                                eqLBL.Text = "Cos⁻¹";
                                eqLBL.Text += EquationTxtbox.Text;
                                if (Radianmode == true)
                                {
                                    result = Math.Acos(Double.Parse(EquationTxtbox.Text)) * (180 / Math.PI);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                                else
                                {
                                    radians = (Double.Parse(EquationTxtbox.Text));
                                    result = Math.Acos(radians);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                            }
                            break;
                        case "Sin":

                            if (shifted == false)
                            {
                                eqLBL.Text = "Sin";
                                eqLBL.Text += EquationTxtbox.Text;
                                if (Radianmode == true)
                                {

                                    radians = (Double.Parse(EquationTxtbox.Text)) * (Math.PI / 180);
                                    result = Math.Sin(radians);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                                else
                                {
                                    result = Math.Sin(Double.Parse(EquationTxtbox.Text));
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                            }
                            else
                            {
                                eqLBL.Text = "Sin⁻¹";
                                eqLBL.Text += EquationTxtbox.Text;
                                if (Radianmode == true)
                                {
                                    result = Math.Asin(Double.Parse(EquationTxtbox.Text)) * (180 / Math.PI);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                                else
                                {
                                    radians = (Double.Parse(EquationTxtbox.Text));
                                    result = Math.Asin(radians);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                            }
                            break;
                        case "Tan":

                            if (shifted == false)
                            {
                                eqLBL.Text = "Tan";
                                eqLBL.Text += EquationTxtbox.Text;
                                if (Radianmode == true)
                                {

                                    radians = (Double.Parse(EquationTxtbox.Text)) * (Math.PI / 180);
                                    result = Math.Tan(radians);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                                else
                                {
                                    result = Math.Tan(Double.Parse(EquationTxtbox.Text));
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                            }
                            else
                            {
                                eqLBL.Text = "Tan⁻¹";
                                eqLBL.Text += EquationTxtbox.Text;
                                if (Radianmode == true)
                                {
                                    result = Math.Atan(Double.Parse(EquationTxtbox.Text)) * (180 / Math.PI);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                                else
                                {
                                    radians = (Double.Parse(EquationTxtbox.Text));
                                    result = Math.Atan(radians);
                                    EquationTxtbox.Text = result.ToString();
                                    Holding = result;

                                    if (AutoRound.CheckState == CheckState.Checked)
                                    {
                                        Ans = Math.Round(Holding, 2, MidpointRounding.AwayFromZero);
                                        EquationTxtbox.Text = String.Format("{0:0.00}", Ans);
                                    }
                                }
                            }
                            break;
                        case "overx":
                            eqLBL.Text = "1/";
                            eqLBL.Text += EquationTxtbox.Text;
                            break;
                        default:
                            break;
                    }
                        flagOpPressed = true;
                        EquationTxtbox.SelectionStart = EquationTxtbox.Text.Length;
                        EquationTxtbox.Select();

                }
                else
                {
                    syn.Speak("Can not have 2 operators in a row");
                    MessageBox.Show("Can not have 2 operators in a row", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

