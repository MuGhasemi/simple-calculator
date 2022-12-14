namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
            txtNumber1.ResetText();
            txtNumber2.ResetText();
            txtResult.ResetText();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int sum = calculate.Plus((int)txtNumber1.Value,
                                           (int)txtNumber2.Value);
                txtResult.Value = sum;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                try
                {
                    int minus = calculate.Minus((int)txtNumber1.Value,
                                                (int)txtNumber2.Value);
                    txtResult.Value = minus;
                }
                catch
                {
                    MessageBox.Show("Number1 smaller than Number2 !");
                }
            }

        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int multiplication = calculate.Multiplication((int)txtNumber1.Value,
                                                                (int)txtNumber2.Value);
                txtResult.Value = multiplication;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int divide = calculate.Divide((int)txtNumber1.Value,
                                                (int)txtNumber2.Value);
                txtResult.Value = divide;
            }
        }

        bool ValidateInputs()
        {
            bool isValid = true;
            if (txtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("Please Enter Number1 !");
            }
            else
            {
                if (txtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("Please Enter Number2 !");
                }
            }
            return isValid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.ResetText();
            txtNumber2.ResetText();
            txtResult.ResetText();
        }
    }
}