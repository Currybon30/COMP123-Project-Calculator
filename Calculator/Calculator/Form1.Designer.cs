namespace Calculator
{
    partial class myCal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myCal));
            tabAboutMe = new TabControl();
            tabCal = new TabPage();
            btnSub = new Button();
            btnAdd = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            btn1DivX = new Button();
            btnSqrt = new Button();
            btnResult = new Button();
            btnClear = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnAddSub = new Button();
            rbtnScientific = new RadioButton();
            rbtnStandard = new RadioButton();
            cbDark = new CheckBox();
            txtResult = new TextBox();
            tabAbout = new TabPage();
            label3 = new Label();
            label1 = new Label();
            listInfo = new ListBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tabAboutMe.SuspendLayout();
            tabCal.SuspendLayout();
            tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabAboutMe
            // 
            tabAboutMe.Controls.Add(tabCal);
            tabAboutMe.Controls.Add(tabAbout);
            tabAboutMe.Location = new Point(3, 2);
            tabAboutMe.Name = "tabAboutMe";
            tabAboutMe.SelectedIndex = 0;
            tabAboutMe.Size = new Size(536, 584);
            tabAboutMe.TabIndex = 2;
            // 
            // tabCal
            // 
            tabCal.BackColor = Color.White;
            tabCal.Controls.Add(btnSub);
            tabCal.Controls.Add(btnAdd);
            tabCal.Controls.Add(btnDiv);
            tabCal.Controls.Add(btnMul);
            tabCal.Controls.Add(btn1DivX);
            tabCal.Controls.Add(btnSqrt);
            tabCal.Controls.Add(btnResult);
            tabCal.Controls.Add(btnClear);
            tabCal.Controls.Add(btn3);
            tabCal.Controls.Add(btn2);
            tabCal.Controls.Add(btn1);
            tabCal.Controls.Add(btn5);
            tabCal.Controls.Add(btn4);
            tabCal.Controls.Add(btn6);
            tabCal.Controls.Add(btn7);
            tabCal.Controls.Add(btn8);
            tabCal.Controls.Add(btn9);
            tabCal.Controls.Add(btn0);
            tabCal.Controls.Add(btnDot);
            tabCal.Controls.Add(btnAddSub);
            tabCal.Controls.Add(rbtnScientific);
            tabCal.Controls.Add(rbtnStandard);
            tabCal.Controls.Add(cbDark);
            tabCal.Controls.Add(txtResult);
            tabCal.Location = new Point(4, 29);
            tabCal.Name = "tabCal";
            tabCal.Padding = new Padding(3);
            tabCal.Size = new Size(528, 551);
            tabCal.TabIndex = 0;
            tabCal.Text = "Calculator";
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Orange;
            btnSub.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.ForeColor = SystemColors.ButtonHighlight;
            btnSub.Location = new Point(354, 258);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(72, 78);
            btnSub.TabIndex = 35;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Orange;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(276, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(72, 78);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.Orange;
            btnDiv.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.ForeColor = SystemColors.ButtonHighlight;
            btnDiv.Location = new Point(354, 342);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(72, 78);
            btnDiv.TabIndex = 33;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.Orange;
            btnMul.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnMul.ForeColor = SystemColors.ButtonHighlight;
            btnMul.Location = new Point(276, 342);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(72, 78);
            btnMul.TabIndex = 32;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btn1DivX
            // 
            btn1DivX.BackColor = Color.CornflowerBlue;
            btn1DivX.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btn1DivX.ForeColor = SystemColors.ButtonHighlight;
            btn1DivX.Location = new Point(276, 426);
            btn1DivX.Name = "btn1DivX";
            btn1DivX.Size = new Size(72, 78);
            btn1DivX.TabIndex = 31;
            btn1DivX.Text = "1/X";
            btn1DivX.UseVisualStyleBackColor = false;
            btn1DivX.Click += btn1DivX_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.CornflowerBlue;
            btnSqrt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqrt.ForeColor = SystemColors.ButtonHighlight;
            btnSqrt.Location = new Point(354, 426);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(72, 78);
            btnSqrt.TabIndex = 30;
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.CornflowerBlue;
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnResult.ForeColor = SystemColors.ButtonHighlight;
            btnResult.Location = new Point(432, 258);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(79, 246);
            btnResult.TabIndex = 29;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Footlight MT Light", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(276, 174);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(235, 78);
            btnClear.TabIndex = 28;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Black;
            btn3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(181, 342);
            btn3.Name = "btn3";
            btn3.Size = new Size(72, 78);
            btn3.TabIndex = 27;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Black;
            btn2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(103, 342);
            btn2.Name = "btn2";
            btn2.Size = new Size(72, 78);
            btn2.TabIndex = 26;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Black;
            btn1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(25, 342);
            btn1.Name = "btn1";
            btn1.Size = new Size(72, 78);
            btn1.TabIndex = 25;
            btn1.TabStop = false;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Black;
            btn5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(103, 258);
            btn5.Name = "btn5";
            btn5.Size = new Size(72, 78);
            btn5.TabIndex = 24;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Black;
            btn4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(25, 258);
            btn4.Name = "btn4";
            btn4.Size = new Size(72, 78);
            btn4.TabIndex = 23;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Black;
            btn6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(181, 258);
            btn6.Name = "btn6";
            btn6.Size = new Size(72, 78);
            btn6.TabIndex = 22;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Black;
            btn7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(25, 174);
            btn7.Name = "btn7";
            btn7.Size = new Size(72, 78);
            btn7.TabIndex = 21;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Black;
            btn8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(103, 174);
            btn8.Name = "btn8";
            btn8.Size = new Size(72, 78);
            btn8.TabIndex = 20;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Black;
            btn9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(181, 174);
            btn9.Name = "btn9";
            btn9.Size = new Size(72, 78);
            btn9.TabIndex = 19;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Black;
            btn0.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(25, 426);
            btn0.Name = "btn0";
            btn0.Size = new Size(72, 78);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.Black;
            btnDot.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnDot.ForeColor = SystemColors.ButtonHighlight;
            btnDot.Location = new Point(103, 426);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(72, 78);
            btnDot.TabIndex = 16;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnAddSub
            // 
            btnAddSub.BackColor = Color.Black;
            btnAddSub.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSub.ForeColor = SystemColors.ButtonHighlight;
            btnAddSub.Location = new Point(181, 426);
            btnAddSub.Name = "btnAddSub";
            btnAddSub.Size = new Size(72, 78);
            btnAddSub.TabIndex = 15;
            btnAddSub.Text = "±";
            btnAddSub.UseVisualStyleBackColor = false;
            btnAddSub.Click += btnAddSub_Click;
            // 
            // rbtnScientific
            // 
            rbtnScientific.AutoSize = true;
            rbtnScientific.Location = new Point(214, 113);
            rbtnScientific.Name = "rbtnScientific";
            rbtnScientific.Size = new Size(90, 24);
            rbtnScientific.TabIndex = 3;
            rbtnScientific.Text = "Scie&ntific";
            rbtnScientific.UseVisualStyleBackColor = true;
            rbtnScientific.CheckedChanged += rbtnScientific_CheckedChanged;
            // 
            // rbtnStandard
            // 
            rbtnStandard.AutoSize = true;
            rbtnStandard.Checked = true;
            rbtnStandard.Location = new Point(51, 113);
            rbtnStandard.Name = "rbtnStandard";
            rbtnStandard.Size = new Size(90, 24);
            rbtnStandard.TabIndex = 2;
            rbtnStandard.TabStop = true;
            rbtnStandard.Text = "&Standard";
            rbtnStandard.UseVisualStyleBackColor = true;
            rbtnStandard.CheckedChanged += rbtnStandard_CheckedChanged;
            // 
            // cbDark
            // 
            cbDark.AutoSize = true;
            cbDark.Location = new Point(385, 113);
            cbDark.Name = "cbDark";
            cbDark.Size = new Size(105, 24);
            cbDark.TabIndex = 1;
            cbDark.Text = "&Dark Mode";
            cbDark.UseVisualStyleBackColor = true;
            cbDark.CheckedChanged += cbDark_CheckedChanged;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.ControlLightLight;
            txtResult.Cursor = Cursors.Hand;
            txtResult.Font = new Font("Microsoft Sans Serif", 29.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(25, 17);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(486, 64);
            txtResult.TabIndex = 0;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // tabAbout
            // 
            tabAbout.Controls.Add(label3);
            tabAbout.Controls.Add(label1);
            tabAbout.Controls.Add(listInfo);
            tabAbout.Controls.Add(pictureBox2);
            tabAbout.Controls.Add(pictureBox1);
            tabAbout.Location = new Point(4, 29);
            tabAbout.Name = "tabAbout";
            tabAbout.Padding = new Padding(3);
            tabAbout.Size = new Size(528, 551);
            tabAbout.TabIndex = 1;
            tabAbout.Text = "About Me";
            tabAbout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 167);
            label3.Name = "label3";
            label3.Size = new Size(230, 60);
            label3.TabIndex = 5;
            label3.Text = "ⓘ Please choose one field below.\r\nMy Information will be showed \r\nin a message box.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 515);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 4;
            label1.Text = "© 2023 Pham Tuong Nguyen";
            // 
            // listInfo
            // 
            listInfo.FormattingEnabled = true;
            listInfo.ItemHeight = 20;
            listInfo.Items.AddRange(new object[] { "My Personal Info", "My Contact" });
            listInfo.Location = new Point(265, 265);
            listInfo.Name = "listInfo";
            listInfo.Size = new Size(230, 44);
            listInfo.TabIndex = 2;
            listInfo.SelectedIndexChanged += listInfo_SelectedIndexChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(69, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 118);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(30, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // myCal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(541, 573);
            Controls.Add(tabAboutMe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "myCal";
            Text = "Nguyen Calculator";
            tabAboutMe.ResumeLayout(false);
            tabCal.ResumeLayout(false);
            tabCal.PerformLayout();
            tabAbout.ResumeLayout(false);
            tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAboutMe;
        private TabPage tabCal;
        private TextBox txtResult;
        private CheckBox cbDark;
        private RadioButton rbtnScientific;
        private RadioButton rbtnStandard;
        private Button btn1DivX;
        private Button btnSqrt;
        private Button btnClear;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn5;
        private Button btn4;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDot;
        private Button btnAddSub;
        private Button btnSub;
        private Button btnAdd;
        private Button btnDiv;
        private Button btnMul;
        private TabPage tabAbout;
        private Button btnResult;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listInfo;
        private Label label1;
        private Label label3;
    }
}