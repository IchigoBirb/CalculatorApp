namespace Calculator_222114X
{
    partial class MainForm_222114X
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblID = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.deci = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btnLg = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.eqLBL = new System.Windows.Forms.Label();
            this.EquationTxtbox = new System.Windows.Forms.TextBox();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.xovery = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.Radian = new System.Windows.Forms.Button();
            this.AutoRound = new System.Windows.Forms.CheckBox();
            this.Copy = new System.Windows.Forms.Button();
            this.Notif = new System.Windows.Forms.CheckBox();
            this.STD = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.CheckBox();
            this.Sound = new System.Windows.Forms.CheckBox();
            this.Mode = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.STDSCI = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SHIFT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblID.Location = new System.Drawing.Point(23, 498);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(327, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Done by : Cheung Xin Yan Jason (222114X) Group : E3";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.Chartreuse;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Display.Location = new System.Drawing.Point(12, 49);
            this.Display.Margin = new System.Windows.Forms.Padding(15);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(374, 79);
            this.Display.TabIndex = 1;
            this.Display.Text = "";
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn7.Location = new System.Drawing.Point(10, 279);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 51);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.NumPad);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn8.Location = new System.Drawing.Point(87, 279);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 51);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.NumPad);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn9.Location = new System.Drawing.Point(163, 279);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 51);
            this.btn9.TabIndex = 4;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.NumPad);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(239, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 51);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operatorClick);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn4.Location = new System.Drawing.Point(10, 336);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 50);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.NumPad);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn5.Location = new System.Drawing.Point(87, 336);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 50);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.NumPad);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn6.Location = new System.Drawing.Point(163, 336);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 50);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.NumPad);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMult.Location = new System.Drawing.Point(239, 336);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(70, 50);
            this.btnMult.TabIndex = 9;
            this.btnMult.Tag = "Mult";
            this.btnMult.Text = "×";
            this.btnMult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.operatorClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1.Location = new System.Drawing.Point(10, 392);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 49);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.NumPad);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2.Location = new System.Drawing.Point(87, 392);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 49);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.NumPad);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn3.Location = new System.Drawing.Point(163, 392);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 49);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.NumPad);
            // 
            // deci
            // 
            this.deci.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deci.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deci.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deci.Location = new System.Drawing.Point(239, 392);
            this.deci.Name = "deci";
            this.deci.Size = new System.Drawing.Size(70, 49);
            this.deci.TabIndex = 13;
            this.deci.Text = ".";
            this.deci.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deci.UseVisualStyleBackColor = false;
            this.deci.Click += new System.EventHandler(this.NumPad);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPower.Location = new System.Drawing.Point(239, 222);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(70, 51);
            this.btnPower.TabIndex = 14;
            this.btnPower.Tag = "Power";
            this.btnPower.Text = "xʸ";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.operatorClick);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn0.Location = new System.Drawing.Point(87, 447);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(70, 48);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.NumPad);
            // 
            // btnSqrt
            // 
            this.btnSqrt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSqrt.Location = new System.Drawing.Point(86, 222);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(71, 51);
            this.btnSqrt.TabIndex = 16;
            this.btnSqrt.Tag = "Sqrt";
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnEqu
            // 
            this.btnEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqu.Location = new System.Drawing.Point(315, 447);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(71, 48);
            this.btnEqu.TabIndex = 17;
            this.btnEqu.Tag = "Equ";
            this.btnEqu.Text = "=";
            this.btnEqu.UseVisualStyleBackColor = true;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinus.Location = new System.Drawing.Point(315, 279);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(71, 51);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.Tag = "Minus";
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.operatorClick);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDiv.Location = new System.Drawing.Point(315, 336);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(70, 50);
            this.btnDiv.TabIndex = 19;
            this.btnDiv.Tag = "Div";
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.operatorClick);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(239, 447);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(70, 48);
            this.btnCE.TabIndex = 20;
            this.btnCE.Tag = "CE";
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.Location = new System.Drawing.Point(315, 392);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(71, 49);
            this.back.TabIndex = 21;
            this.back.Text = "⌫";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnLg
            // 
            this.btnLg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLg.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLg.Location = new System.Drawing.Point(10, 167);
            this.btnLg.Name = "btnLg";
            this.btnLg.Size = new System.Drawing.Size(70, 49);
            this.btnLg.TabIndex = 22;
            this.btnLg.Tag = "Lg";
            this.btnLg.Text = "x Log⏨";
            this.btnLg.UseVisualStyleBackColor = false;
            this.btnLg.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnLn.Location = new System.Drawing.Point(86, 167);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(71, 49);
            this.btnLn.TabIndex = 23;
            this.btnLn.Tag = "Ln";
            this.btnLn.Text = "ln x";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnCos.Location = new System.Drawing.Point(163, 167);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(70, 49);
            this.btnCos.TabIndex = 24;
            this.btnCos.Tag = "Cos";
            this.btnCos.Text = "cos θ";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnSin.Location = new System.Drawing.Point(239, 167);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(71, 49);
            this.btnSin.TabIndex = 25;
            this.btnSin.Tag = "Sin";
            this.btnSin.Text = "sin θ";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnTan.Location = new System.Drawing.Point(315, 167);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(69, 49);
            this.btnTan.TabIndex = 26;
            this.btnTan.Tag = "Tan";
            this.btnTan.Text = "tan θ";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // eqLBL
            // 
            this.eqLBL.AutoSize = true;
            this.eqLBL.BackColor = System.Drawing.Color.Chartreuse;
            this.eqLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqLBL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eqLBL.Location = new System.Drawing.Point(22, 52);
            this.eqLBL.Name = "eqLBL";
            this.eqLBL.Size = new System.Drawing.Size(150, 20);
            this.eqLBL.TabIndex = 28;
            this.eqLBL.Text = "Type an equation";
            // 
            // EquationTxtbox
            // 
            this.EquationTxtbox.BackColor = System.Drawing.Color.Chartreuse;
            this.EquationTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EquationTxtbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquationTxtbox.ForeColor = System.Drawing.Color.Black;
            this.EquationTxtbox.Location = new System.Drawing.Point(35, 75);
            this.EquationTxtbox.Name = "EquationTxtbox";
            this.EquationTxtbox.Size = new System.Drawing.Size(346, 50);
            this.EquationTxtbox.TabIndex = 29;
            this.EquationTxtbox.Text = "0";
            this.EquationTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EquationTxtbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Keydown);
            // 
            // btnBinary
            // 
            this.btnBinary.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBinary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBinary.Location = new System.Drawing.Point(163, 222);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(70, 51);
            this.btnBinary.TabIndex = 30;
            this.btnBinary.Tag = "Binary";
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = false;
            this.btnBinary.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnAns
            // 
            this.btnAns.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.ForeColor = System.Drawing.Color.Aqua;
            this.btnAns.Location = new System.Drawing.Point(10, 447);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(70, 48);
            this.btnAns.TabIndex = 31;
            this.btnAns.Text = "Ans";
            this.btnAns.UseVisualStyleBackColor = false;
            this.btnAns.Click += new System.EventHandler(this.button2_Click);
            // 
            // xovery
            // 
            this.xovery.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xovery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.xovery.Location = new System.Drawing.Point(315, 222);
            this.xovery.Name = "xovery";
            this.xovery.Size = new System.Drawing.Size(70, 51);
            this.xovery.TabIndex = 32;
            this.xovery.Tag = "overx";
            this.xovery.Text = "¹/ₓ";
            this.xovery.UseVisualStyleBackColor = false;
            this.xovery.Click += new System.EventHandler(this.singleEntryClick);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlusMinus.Location = new System.Drawing.Point(163, 447);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(70, 48);
            this.btnPlusMinus.TabIndex = 33;
            this.btnPlusMinus.Text = "⁺/₋";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMod.Location = new System.Drawing.Point(10, 222);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(70, 51);
            this.btnMod.TabIndex = 34;
            this.btnMod.Tag = "Mod";
            this.btnMod.Text = "%";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.operatorClick);
            // 
            // Radian
            // 
            this.Radian.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Radian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radian.ForeColor = System.Drawing.Color.Cyan;
            this.Radian.Location = new System.Drawing.Point(315, 128);
            this.Radian.Name = "Radian";
            this.Radian.Size = new System.Drawing.Size(70, 32);
            this.Radian.TabIndex = 35;
            this.Radian.Text = "DEG";
            this.Radian.UseVisualStyleBackColor = false;
            this.Radian.Click += new System.EventHandler(this.Radian_Click);
            // 
            // AutoRound
            // 
            this.AutoRound.AutoSize = true;
            this.AutoRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRound.ForeColor = System.Drawing.Color.DarkOrange;
            this.AutoRound.Location = new System.Drawing.Point(12, 7);
            this.AutoRound.Name = "AutoRound";
            this.AutoRound.Size = new System.Drawing.Size(110, 19);
            this.AutoRound.TabIndex = 37;
            this.AutoRound.Text = "Auto Rounding";
            this.AutoRound.UseVisualStyleBackColor = true;
            this.AutoRound.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.Cyan;
            this.Copy.Location = new System.Drawing.Point(239, 128);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(70, 32);
            this.Copy.TabIndex = 38;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // Notif
            // 
            this.Notif.AutoSize = true;
            this.Notif.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notif.ForeColor = System.Drawing.Color.DarkOrange;
            this.Notif.Location = new System.Drawing.Point(12, 25);
            this.Notif.Name = "Notif";
            this.Notif.Size = new System.Drawing.Size(112, 19);
            this.Notif.TabIndex = 39;
            this.Notif.Text = "Announcement";
            this.Notif.UseVisualStyleBackColor = true;
            this.Notif.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // STD
            // 
            this.STD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.STD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STD.ForeColor = System.Drawing.Color.Cyan;
            this.STD.Location = new System.Drawing.Point(10, 128);
            this.STD.Name = "STD";
            this.STD.Size = new System.Drawing.Size(70, 32);
            this.STD.TabIndex = 41;
            this.STD.Text = "STD";
            this.STD.UseVisualStyleBackColor = false;
            this.STD.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Color
            // 
            this.Color.AutoSize = true;
            this.Color.ForeColor = System.Drawing.Color.DarkOrange;
            this.Color.Location = new System.Drawing.Point(140, 6);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(109, 20);
            this.Color.TabIndex = 42;
            this.Color.Text = "Color change";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Sound
            // 
            this.Sound.AutoSize = true;
            this.Sound.ForeColor = System.Drawing.Color.DarkOrange;
            this.Sound.Location = new System.Drawing.Point(140, 25);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(81, 20);
            this.Sound.TabIndex = 43;
            this.Sound.Text = "Speaker";
            this.Sound.UseVisualStyleBackColor = true;
            this.Sound.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.BackColor = System.Drawing.Color.Chartreuse;
            this.Mode.Location = new System.Drawing.Point(332, 53);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(51, 16);
            this.Mode.TabIndex = 45;
            this.Mode.Text = "Radian";
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(163, 128);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(70, 33);
            this.btnC.TabIndex = 46;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // STDSCI
            // 
            this.STDSCI.AutoSize = true;
            this.STDSCI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.STDSCI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.STDSCI.Location = new System.Drawing.Point(12, 113);
            this.STDSCI.Name = "STDSCI";
            this.STDSCI.Size = new System.Drawing.Size(60, 16);
            this.STDSCI.TabIndex = 47;
            this.STDSCI.Text = "Scientific";
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            // 
            // Logo
            // 
            this.Logo.ErrorImage = null;
            this.Logo.Image = global::Calculator_222114X.Properties.Resources.image;
            this.Logo.Location = new System.Drawing.Point(253, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(128, 42);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 44;
            this.Logo.TabStop = false;
            // 
            // SHIFT
            // 
            this.SHIFT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SHIFT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHIFT.ForeColor = System.Drawing.Color.Cyan;
            this.SHIFT.Location = new System.Drawing.Point(87, 128);
            this.SHIFT.Name = "SHIFT";
            this.SHIFT.Size = new System.Drawing.Size(70, 32);
            this.SHIFT.TabIndex = 49;
            this.SHIFT.TabStop = false;
            this.SHIFT.Text = "Shift";
            this.SHIFT.UseVisualStyleBackColor = false;
            this.SHIFT.Click += new System.EventHandler(this.SHIFT_Click);
            // 
            // MainForm_222114X
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(393, 519);
            this.Controls.Add(this.SHIFT);
            this.Controls.Add(this.STDSCI);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.STD);
            this.Controls.Add(this.Notif);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.AutoRound);
            this.Controls.Add(this.Radian);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.xovery);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.EquationTxtbox);
            this.Controls.Add(this.eqLBL);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnLg);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnEqu);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.deci);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.lblID);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(411, 566);
            this.MinimumSize = new System.Drawing.Size(411, 566);
            this.Name = "MainForm_222114X";
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_222114X_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_222114X_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button deci;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnLg;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Label eqLBL;
        private System.Windows.Forms.TextBox EquationTxtbox;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button xovery;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button Radian;
        private System.Windows.Forms.CheckBox AutoRound;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.CheckBox Notif;
        private System.Windows.Forms.Button STD;
        private System.Windows.Forms.CheckBox Color;
        private System.Windows.Forms.CheckBox Sound;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label STDSCI;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button SHIFT;
    }
}

