namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string operation;
        double Number1;
        double Number2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Entraste na calculadora");
        }

        private void n1_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(1);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(2);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(3);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(4);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(5);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(6);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(7);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(8);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(9);
        }

        private void n0_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + Convert.ToString(0);
        }

        private void soma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = Convert.ToDouble(resultado.Text);
                operation = "+";
                resultado.Clear();
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }

        }

        private void subtrair_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = Convert.ToDouble(resultado.Text);
                operation = "-";
                resultado.Clear();
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = Convert.ToDouble(resultado.Text);
                operation = "*";
                resultado.Clear();
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = Convert.ToDouble(resultado.Text);
                operation = "/";
                resultado.Clear();
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(resultado.Text);

            switch (operation)
            {
                case "+":
                    double resultadoSoma = Number1 + Number2;
                    resultado.Text = Convert.ToString(resultadoSoma);
                    break;
                case "-":
                    double resultadoSubtracao = Number1 - Number2;
                    resultado.Text = Convert.ToString(resultadoSubtracao);
                    break;
                case "*":
                    double resultadoMultiplicacao = Number1 * Number2;
                    resultado.Text = Convert.ToString(resultadoMultiplicacao);
                    break;
                case "/":
                    double resultadoDivisao = Number1 / Number2;
                    resultado.Text = Convert.ToString(resultadoDivisao);
                    break;
                case "%":
                    double resultadoResto = Number1 % Number2;
                    resultado.Text = Convert.ToString(resultadoResto);
                    break;
                default:
                    MessageBox.Show("Não executaste nenhuma operação!");
                    break;
            }
        }

        private void colon_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ",";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                resultado.Text = resultado.Text.Remove(resultado.Text.Length - 1);
            }
            else
            {
                MessageBox.Show("Já não há números na caixa!");
            }
        }

        private void button21_Click(object sender, EventArgs e) // raiz quadrada
        {
            if (!string.IsNullOrEmpty(resultado.Text))
                resultado.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(resultado.Text)));

            else MessageBox.Show("Não há caracteres!");
        }

        private void m_o_m_Click(object sender, EventArgs e) // +/_ 
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                double textbox_Content = Convert.ToDouble(resultado.Text);
                resultado.Text = Convert.ToString((double)-textbox_Content);
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }
        }

        private void button24_Click(object sender, EventArgs e) // Resto da divisao
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = Convert.ToDouble(resultado.Text);
                operation = "%";
                resultado.Clear();
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }
        }

        private void button23_Click(object sender, EventArgs e) // 1/x
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = 1 / Convert.ToDouble(resultado.Text);
                resultado.Text = Convert.ToString(Number1);
            }
            else
            {
                MessageBox.Show("Não há caracteres!");
            }
        }

        private void button22_Click(object sender, EventArgs e) // x2
        {
            if (!string.IsNullOrEmpty(resultado.Text))
            {
                Number1 = Convert.ToDouble(resultado.Text);
                double res = Number1 * Number1;
                resultado.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Não executaste nenhuma operação!");
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            resultado.Clear();
        }
    }
}