using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Fretes
{
    public partial class FretesForm : Form
    {
        public FretesForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var erros = ValidarFormulario();

            //if (!erros.Any())
            if (erros.Count == 0)
            {
                Calcular();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine,erros),
                                "Validação",MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Realiza a validação do formulário
        /// </summary>
        /// <returns>Se for true, quer dizer que os campos estão OK, e false, para campos inconsistentes </returns>
        private List<string> ValidarFormulario()
        {
            var erros = new List<string>();

            if (clienteTextBox.Text.Trim() == string.Empty)
            {
                erros.Add("Informe o nome do Cliente !");
            }

            if (string.IsNullOrEmpty(valorTextBox.Text.Trim()))
            {
                erros.Add("Informe o campo valor !");
            }
            else
            {
                // C# antigo
                //decimal valor;
                //if (decimal.TryParse(valorTextBox.Text.Trim(), out valor))

                //C# 7
                if (!decimal.TryParse(valorTextBox.Text.Trim(), out decimal valor))
                {
                    erros.Add("O campo valor deve ser numérico !");
                }
            }

            if (ufComboBox.SelectedIndex == -1)
            {
                erros.Add("Selecione a UF de destino !");
            }

            return erros;
        }

        private void Calcular()
        {
            decimal percentual = 0m;
            decimal valor = Convert.ToDecimal(valorTextBox.Text);
            var nordeste = new List<string>{"BA","PE","AL"};

            switch (ufComboBox.Text.ToUpper())
            {
                case "AM":
                    percentual = 0.6m;
                    break;
                case var uf when nordeste.Contains(uf):
                    percentual = 0.5m;
                    break;
                case "MG":
                    percentual = 0.35m;
                    break;
                case "RJ":
                    percentual = 0.3m;
                    break;
                case "SP":
                    percentual = 0.2m;
                    break;
                case null:
                    throw new NullReferenceException("A UF não pode ser nula.");
                default:
                    percentual = 0.75m;
                    break;
            }

            //Devolver na tela o valor da textbox formatado
            valorTextBox.Text = valor.ToString("N2");

            //Devolver na tela o valor do frete calculado
            freteTextBox.Text = percentual.ToString("P2");
            totalTextBox.Text = (valor * (1 + percentual)).ToString("C");

        }

        private void Limpar()
        {
            clienteTextBox.Clear();
            valorTextBox.Clear();
            ufComboBox.SelectedIndex = -1;
            freteTextBox.Clear();
            totalTextBox.Clear();
            clienteTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
