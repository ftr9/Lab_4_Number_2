namespace Lab_4_Number_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _CalculateAndDisplayFactors(int num)
        {
            List<int> factors = new List<int>();
            for(int i = num; i > 0; i--)
            {
                if(num%i == 0)
                {
                    factors.Add(i);
                }
            }

            //Combine the factors in string
            string result = "";
            foreach(int i in factors)
            {
                result += i.ToString()+" , ";
            }

            MessageBox.Show($" factors of {num} are {result}");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(TextInput.Text);
                if(num <= 0) {
                    throw new Exception("Please Provide number greater than 0");
                }

                this._CalculateAndDisplayFactors(num);

            }
            catch (FormatException ex) {
                MessageBox.Show("Please provide number - characters are not allowed");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}