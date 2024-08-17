namespace Calculator
{
    public partial class myCal : Form
    {
        private double numOne = 0.0;
        private double numTwo = 0.0;
        private double result = 0.0;
        private string operators = "";
        public myCal()
        {
            InitializeComponent();
        }

        private void cbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDark.Checked)
            {
                tabCal.BackColor = Color.DarkGray;
                tabAbout.BackColor = Color.DarkGray;
            }
            else
            {
                tabCal.BackColor = Color.White;
                tabAbout.BackColor = Color.White;
            }

        }
        private Button btnPower2 = new Button();
        private Button btnLog = new Button();
        private Button btnFactorial = new Button();
        private Button btnPI = new Button();
        private void rbtnScientific_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnScientific.Checked)
            {
                myCal myCal = new myCal();
                myCal.Size = new Size(668, 640);
                btnClear.Size = new Size(306, 78);
                btnResult.Size = new Size(150, 78);
                btnResult.Location = new Point(432, 426);
                tabAboutMe.Size = new Size(626, 568);
                txtResult.Size = new Size(557, 63);

                Font buttonFont = new Font("Segoe UI", 18);
                //X^2
                btnPower2.Size = new Size(72, 78);
                btnPower2.BackColor = Color.CornflowerBlue;
                btnPower2.ForeColor = Color.White;
                btnPower2.Text = "X²";
                btnPower2.Location = new Point(432, 259);
                btnPower2.Font = buttonFont;
                //log
                btnLog.Size = new Size(72, 78);
                btnLog.BackColor = Color.CornflowerBlue;
                btnLog.ForeColor = Color.White;
                btnLog.Text = "log";
                btnLog.Location = new Point(432, 342);
                btnLog.Font = buttonFont;
                //Factorial
                btnFactorial.Size = new Size(72, 78);
                btnFactorial.BackColor = Color.CornflowerBlue;
                btnFactorial.ForeColor = Color.White;
                btnFactorial.Text = "X!";
                btnFactorial.Location = new Point(510, 260);
                btnFactorial.Font = buttonFont;
                //PI
                btnPI.Size = new Size(72, 78);
                btnPI.BackColor = Color.CornflowerBlue;
                btnPI.ForeColor = Color.White;
                btnPI.Text = "π";
                btnPI.Location = new Point(510, 342);
                btnPI.Font = buttonFont;
                //Add buttons
                tabAboutMe.TabPages[0].Controls.Add(btnPower2);
                btnPower2.BringToFront();
                btnPower2.Click += btnPower2_Click;
                tabAboutMe.TabPages[0].Controls.Add(btnLog);
                btnLog.BringToFront();
                btnLog.Click += btnLog_Click;
                tabAboutMe.TabPages[0].Controls.Add(btnFactorial);
                btnFactorial.BringToFront();
                btnFactorial.Click += btnFactorial_Click;
                tabAboutMe.TabPages[0].Controls.Add(btnPI);
                btnPI.BringToFront();
                btnPI.Click += btnPI_Click;
                txtResult.Text = "0";
            }
        }

        private void rbtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnStandard.Checked)
            {
                myCal myCal = new myCal();
                myCal.Size = new Size(582, 640);
                myCal.AutoSize = true;
                btnResult.Size = new Size(79, 246);
                btnResult.Location = new Point(432, 258);
                btnClear.Size = new Size(235, 78);
                tabAboutMe.Size = new Size(540, 568);
                txtResult.Size = new Size(486, 63);
                tabAboutMe.TabPages[0].Controls.Remove(btnPower2);
                tabAboutMe.TabPages[0].Controls.Remove(btnLog);
                tabAboutMe.TabPages[0].Controls.Remove(btnFactorial);
                tabAboutMe.TabPages[0].Controls.Remove(btnPI);
                txtResult.Text = "0";
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "1";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-1";
            }
            else
            {
                txtResult.Text += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "2";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-2";
            }
            else
            {
                txtResult.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "3";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-3";
            }
            else
            {
                txtResult.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "4";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-4";
            }
            else
            {
                txtResult.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "5";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-5";
            }
            else
            {
                txtResult.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "6";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-6";
            }
            else
            {
                txtResult.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "2";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-7";
            }
            else
            {
                txtResult.Text += "2";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "8";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-8";
            }
            else
            {
                txtResult.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "9";
            }
            else if (txtResult.Text == "-0")
            {
                txtResult.Text = "-9";
            }
            else
            {
                txtResult.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text += "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                txtResult.Text += ".";
            }
        }

        private void btnAddSub_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("-"))
            {
                txtResult.Text = txtResult.Text.Trim('-');
            }
            else
            {
                txtResult.Text = "-" + txtResult.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "-";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            operators = "/";
        }

        private void btn1DivX_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            result = Math.Round(1 / numOne, 6);
            txtResult.Text = result.ToString();
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            result = Math.Round(Math.Sqrt(numOne), 6);
            txtResult.Text = result.ToString();
        }
        private void btnPower2_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            result = Math.Round(Math.Pow(numOne, 2), 6);
            txtResult.Text = result.ToString();
        }
        private void btnLog_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            result = Math.Round(Math.Log(numOne, 10), 6);
            txtResult.Text = result.ToString();
        }
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            numOne = double.Parse(txtResult.Text);
            txtResult.Clear();
            result = 1;
            for (int i = 1; i <= numOne; i++)
            {
                result *= i;
            }
            txtResult.Text = result.ToString();
        }
        private void btnPI_Click(object sender, EventArgs e)
        {
            result = 3.141592;
            txtResult.Clear();
            txtResult.Text += result.ToString();
        }


        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    numTwo = double.Parse(txtResult.Text);
                    result = Math.Round(numOne + numTwo, 6);
                    txtResult.Text = Convert.ToString(result);
                    break;
                case "-":
                    numTwo = double.Parse(txtResult.Text);
                    result = Math.Round(numOne - numTwo, 6);
                    txtResult.Text = Convert.ToString(result);
                    break;
                case "*":
                    numTwo = double.Parse(txtResult.Text);
                    result = Math.Round(numOne * numTwo, 6);
                    txtResult.Text = Convert.ToString(result);
                    break;
                case "/":
                    numTwo = double.Parse(txtResult.Text);
                    if (numTwo == 0)
                    {
                        txtResult.Text = "undefined";
                    }
                    else
                    {
                        result = Math.Round(numOne / numTwo, 6);
                        txtResult.Text = Convert.ToString(result);
                    }
                    break;
            }
        }

        private void listInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listInfo.SelectedIndex == 0)
            {
                string label = this.listInfo.GetItemText(this.listInfo.SelectedItem);
                string myPInfo = "Name: Pham Tuong Nguyen\nAge: 18\nSchool: Centennial College\nProgram: Software Engineering Technology\nLength: 3 years";
                MessageBox.Show(myPInfo, label);
            }
            else if (listInfo.SelectedIndex == 1)
            {
                string label = this.listInfo.GetItemText(this.listInfo.SelectedItem);
                string myPInfo = "Phone number: 437 428 6446\nEmail: npham50@my.centennialcollege.ca";
                MessageBox.Show(myPInfo, label);
            }
        }
    }
}