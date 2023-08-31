## Write a program to find the factors of number in windows form application

## Step - 1 in Program.cs file

```
namespace Lab_4_Number_2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
```

## Step - 2 in Form1.Designer.cs file

```
namespace Lab_4_Number_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            TextInput = new TextBox();
            button1 = new Button();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(254, 47);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "Find Factors of Number";
            //
            // TextInput
            //
            TextInput.Location = new Point(254, 122);
            TextInput.Name = "TextInput";
            TextInput.PlaceholderText = "Enter the number";
            TextInput.Size = new Size(198, 27);
            TextInput.TabIndex = 1;
            //
            // button1
            //
            button1.Location = new Point(271, 191);
            button1.Name = "button1";
            button1.Size = new Size(137, 44);
            button1.TabIndex = 2;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TextInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextInput;
        private Button button1;
    }
}

```

## Step - 3 Draw the UI

![image](https://github.com/ftr9/Lab_4_Number_2/assets/60734475/f411d214-94e9-4ddc-b857-0201aad385e7)

## Step - 5 in Form1.cs file

```
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

```

## Step-6 - Draw the result - Mula Haru Output hai

![image](https://github.com/ftr9/Lab_4_Number_2/assets/60734475/4c34c040-c44c-47fb-a794-95d2f1b00a7f)
