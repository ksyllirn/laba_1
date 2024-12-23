using System;
using System.Windows.Forms;

namespace SimpleFormApp
{
    public class MainForm : Form
    {
        private Label preinputLabel_1;
        private TextBox inputTextBox_1;
        private TextBox outputTextBox1_1;
        private TextBox outputTextBox2_1;
        private TextBox outputTextBox3_1;

        private Label preinputLabel_2;
        private TextBox inputTextBox1_2;
        private TextBox inputTextBox2_2;
        private TextBox inputTextBox3_2;
        private TextBox inputTextBox4_2;
        private TextBox outputTextBox_2;

        private Label preinputLabel_3;
        private TextBox inputTextBox_3;
        private TextBox outputTextBox_3;
        private ListBox outputListBox_3;

        private Label preinputLabel_4;
        private ListBox outputListBox_4;
        public MainForm()
        {
            Text = "Задание 1-4";
            Width = 500;
            Height = 650;
            StartPosition = FormStartPosition.CenterScreen;

            preinputLabel_1 = new Label()
            {
                Top = 20,
                Left = 20,
                Width = 200,
            };

        
            inputTextBox_1 = new TextBox()
            {
                Top = 60,
                Left = 20,
                Width = 200
            };

            outputTextBox1_1 = new TextBox()
            {
                Top = 100,
                Left = 20,
                Width = 200,
                ReadOnly = true
            };

            outputTextBox2_1 = new TextBox()
            {
                Top = 140,
                Left = 20,
                Width = 200,
                ReadOnly = true
            };

            outputTextBox3_1 = new TextBox()
            {
                Top = 180,
                Left = 20,
                Width = 200,
                ReadOnly = true
            };

            Controls.Add(preinputLabel_1);
            Controls.Add(inputTextBox_1);
            Controls.Add(outputTextBox1_1);
            Controls.Add(outputTextBox2_1);
            Controls.Add(outputTextBox3_1);

            preinputLabel_1.Text = "Введите периметр квадрата";
            outputTextBox1_1.Text = "Сторона квадрата: ";
            outputTextBox2_1.Text = "Диагональ: ";
            outputTextBox3_1.Text = "Площадь квадрата: ";

            inputTextBox_1.TextChanged += InputTextBox_TextChanged_1;

            preinputLabel_2 = new Label()
            {
                Top = 20,
                Left = 250,
                Width = 200
            };

            inputTextBox1_2 = new TextBox()
            {
                Top = 60,
                Left = 250,
                Width = 200
            };

            inputTextBox2_2 = new TextBox()
            {
                Top = 100,
                Left = 250,
                Width = 200,
            };

            inputTextBox3_2 = new TextBox()
            {
                Top = 140,
                Left = 250,
                Width = 200,
            };

            inputTextBox4_2 = new TextBox()
            {
                Top = 180,
                Left = 250,
                Width = 200,
            };

            outputTextBox_2 = new TextBox()
            {
                Top = 220,
                Left = 250,
                Width = 200,
                ReadOnly = true
            };

            Controls.Add(preinputLabel_2);
            Controls.Add(inputTextBox1_2);
            Controls.Add(inputTextBox2_2);
            Controls.Add(inputTextBox3_2);
            Controls.Add(inputTextBox4_2);
            Controls.Add(outputTextBox_2);

            preinputLabel_2.Text = "Цена A, B, C и введённую сумма D";
            outputTextBox_2.Text = "Сдача: ";

            inputTextBox1_2.TextChanged += InputTextBox_TextChanged_2;
            inputTextBox2_2.TextChanged += InputTextBox_TextChanged_2;
            inputTextBox3_2.TextChanged += InputTextBox_TextChanged_2;
            inputTextBox4_2.TextChanged += InputTextBox_TextChanged_2;

            preinputLabel_3 = new Label()
            {
                Top = 280,
                Left = 20,
                Width = 200,
            };


            inputTextBox_3 = new TextBox()
            {
                Top = 320,
                Left = 20,
                Width = 200
            };

            outputTextBox_3 = new TextBox()
            {
                Top = 360,
                Left = 20,
                Width = 200,
                ReadOnly = true
            };

            outputListBox_3 = new ListBox()
            {
                Top = 280,
                Left = 250,
                Width = 200,
                Height = 80
            };

            Controls.Add(preinputLabel_3);
            Controls.Add(inputTextBox_3);
            Controls.Add(outputTextBox_3);
            Controls.Add(outputListBox_3);

            preinputLabel_3.Text = "Введите число";
            outputTextBox_3.Text = "";

            inputTextBox_3.TextChanged += InputTextBox_TextChanged_3;

            preinputLabel_4 = new Label()
            {
                Top = 420,
                Left = 20,
                Width = 200,
            };

            outputListBox_4 = new ListBox()
            {
                Top = 460,
                Left = 20,
                Width = 200,
                Height = 80
            };

            Controls.Add(preinputLabel_4);
            Controls.Add(outputListBox_4);

            preinputLabel_4.Text = "Результат:";
            ProcessOutput_4();
        }

        private void InputTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string input = inputTextBox_1.Text;
            if (float.TryParse(input, out float value))
            {
                outputTextBox1_1.Text = ProcessOutput1_1(value);
                outputTextBox2_1.Text = ProcessOutput2_1(value);
                outputTextBox3_1.Text = ProcessOutput3_1(value);
            }
            else
            {
                outputTextBox1_1.Text = "Неверный формат ввода";
                outputTextBox2_1.Text = "Неверный формат ввода";
                outputTextBox3_1.Text = "Неверный формат ввода";
            }
        }

        private string ProcessOutput1_1(float input)
        {
            return $"Сторона квадрата: {input/4}";
        }

        private string ProcessOutput2_1(float input)
        {
            return $"Диагональ: {double.Round((Math.Sqrt(2*(input * input))), 2, MidpointRounding.ToEven)}";
        }

        private string ProcessOutput3_1(float input)
        {
            return $"Площадь квадрата: {Math.Pow((input / 4),2)}";
        }

        private void InputTextBox_TextChanged_2(object sender, EventArgs e)
        {
            string input1 = inputTextBox1_2.Text;
            string input2 = inputTextBox2_2.Text;
            string input3 = inputTextBox3_2.Text;
            string total = inputTextBox4_2.Text;
            if (float.TryParse(input1, out float value1) & float.TryParse(input2, out float value2) & float.TryParse(input3, out float value3) & float.TryParse(total, out float total_parsed))
            {
                outputTextBox_2.Text = ProcessOutput_2(value1,value2,value3,total_parsed);
            }
            else
            {
                outputTextBox_2.Text = "Неверный формат ввода";
            }
        }

        private string ProcessOutput_2(float value1, float value2, float value3, float total_parsed)
        {
            float result_2 = total_parsed - (value1 + value2 + value3);
            if (result_2 >= 0)
            {
                return $"Сдача: {result_2}";
            }
            else
            {
                return $"Недостаточно средств";
            }
        }

        private void InputTextBox_TextChanged_3(object sender, EventArgs e)
        {
            string input = inputTextBox_3.Text;
            if (int.TryParse(input, out int value))
            {
                outputTextBox_3.Text = ProcessOutput_3(value);
            }
            else
            {
                outputTextBox_3.Text = "Неверный формат ввода";
            }
        }

        private string ProcessOutput_3(int input)
        {
            var numbers = new Dictionary<int, string>()
            {
                [0] = "Zero",[1] = "One",[2] = "Two",[3] = "Three",[4] = "Four",[5] = "Five",[6] = "Six",[7] = "Seven",[8] = "Eight",[9] = "Nine"
            };

            string num = "";
            if (numbers.TryGetValue(input, out num))
            {
                outputListBox_3.Items.Add(num);
                return $"Добавленное в список число: {num}";
            }
            else
            {
                return $"Неверный формат ввода";
            }
        }
        private void ProcessOutput_4()
        {
            for (double i = 6; i <= 8; i = i + 0.25)
            {
                double res = Math.Pow(Math.Log(i),2)/i;
                outputListBox_4.Items.Add(res);
            }
        }


        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
