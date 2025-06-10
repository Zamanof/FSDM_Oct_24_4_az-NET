namespace NET_11._EventArgs_with_Windows_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddButton.Click += Calculator;
            SubtractButton.Click += Calculator;
            MultipleButton.Click += Calculator;
            DiovideButton.Click += Calculator;
        }

        private void Calculator(object sender, EventArgs e)
        {
            var btn = sender as Button;
            double left = double.Parse(LeftTextBox.Text);
            double right = double.Parse(RightTextBox.Text);
            if (btn.Text == "Add") ResultLabel.Text = (left + right).ToString();
            else if (btn.Text == "Subtract") ResultLabel.Text = (left - right).ToString();
            else if (btn.Text == "Multiple") ResultLabel.Text = (left * right).ToString();
            else if (btn.Text == "Divide")
            {
                if (right == 0) ResultLabel.Text = "Can not division by zero";
                else ResultLabel.Text = (left / right).ToString();
            }
            LeftTextBox.Clear();
            RightTextBox.Clear();
        }

        //private void AddButtonClick(object sender, EventArgs e)
        //{
        //    int left = int.Parse(LeftTextBox.Text);
        //    int right = int.Parse(RightTextBox.Text);
        //    ResultLabel.Text = (left + right).ToString();
        //    LeftTextBox.Clear();
        //    RightTextBox.Clear();

        //}
    }
}
