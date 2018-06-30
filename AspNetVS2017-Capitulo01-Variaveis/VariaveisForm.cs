using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017_Capitulo01_Variaveis
{
    public partial class VariaveisForm : Form
    {
        int _x = 32;
        int _w = 45;
        int _y = 16;
        int _z = 32;

        public VariaveisForm()
        {
            InitializeComponent();
        }

        private void aritimeticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ToDo: exemplificar a diferença entre class e struct
            // Página 24 da apostila Tipagens de Váriaveis
            // Váriavel inteira.
            int a = 2;
            int b = 6;
            int c = 10;
            var d = 13;
            var Subtotal = (a + b + c + d);
            var total = (Subtotal / 4);

            resultadoListBox.Items.Add("Váriavel a = " + a.ToString());
            resultadoListBox.Items.Add(string.Concat("Váriavel b = ", b));
            //resultadoListBox.Items.Add("Váriavel b = " + b.ToString());
            //resultadoListBox.Items.Add("Váriavel c = " + c.ToString());
            resultadoListBox.Items.Add(string.Format("Váriavel c = {0:c}",c));
            resultadoListBox.Items.Add($"Váriavel d = {d}");

            resultadoListBox.Items.Add("multiplicação de c * d = " + (c * d));
            resultadoListBox.Items.Add("Divisão de c / d = " + (c / Convert.ToDecimal(d)).ToString("F2") );
            resultadoListBox.Items.Add("Módulo de d % a = " + (c % d));

            //decimal bimestre_01 = 4.44m;
            //string meuNome = "Ricardo da Cunha";
            //var nascimento = new DateTime(1974, 05, 19);
            //var @int = 10;
            //a = "42"; // Estaticamente tipada
            //a = int.Parse("42");
            // O @int quando a palavra for reservada e quer dar o nome da váriavel mesmo assim
            //var total = (a + b + c + d) / 2;

        }

        private void reduzidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = 5;
            resultadoListBox.Items.Add("Váriavel x = " + x.ToString());

            x -= 3;
            resultadoListBox.Items.Add("Váriavel x - 3 = " + x.ToString());

        }

        private void incrmentaisDecrementaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = 5;
            resultadoListBox.Items.Add("Váriavel Pré-Incremental");
            resultadoListBox.Items.Add("x = " + x.ToString());
            resultadoListBox.Items.Add("2+ ++x = " + (2 + ++x).ToString());
            resultadoListBox.Items.Add("x = " + x.ToString());

            resultadoListBox.Items.Add("-----------------------------------");
            x = 5;
            resultadoListBox.Items.Add("Váriavel Pós-Incremental");
            resultadoListBox.Items.Add("x = " + x.ToString());
            resultadoListBox.Items.Add("2+ x++ = " + (2 + x++).ToString());
            resultadoListBox.Items.Add("x = " + x.ToString());

            //x--;
            //resultadoListBox.Items.Add("Váriavel Decremental x = " + x.ToString());
        }

        private void booleanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValorDeVariaveis();
        }


        private void logicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibirValorDeVariaveis();
            ExibirValoresBooleanas();
            exibirOperadores();
        }

        private void ExibirValorDeVariaveis()
        {
            resultadoListBox.Items.Add("x => " + _x);
            resultadoListBox.Items.Add("w => " + _w);
            resultadoListBox.Items.Add("y => " + _y);
            resultadoListBox.Items.Add("x => " + _z);

            resultadoListBox.Items.Add(new string('-', 50));
        }

        private void ExibirValoresBooleanas()
        {
            resultadoListBox.Items.Add("w <= x : " + (_x <= _w));
            resultadoListBox.Items.Add("x == z : " + (_x == _z));
            resultadoListBox.Items.Add("x != z : " + (_x != _z));
        }

        private void precedencia()
        {
            // Precedencia
            // 1º. Negação.
            // 2º. E(&&).
            // 3º. Ou (||).
            int ano = 2018;
            // Ternário == iif()
            // (ano % 4 == 0 ? "Sim":"Não")
            resultadoListBox.Items.Add($"O Ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim":"Não")}.");

            ano = 2020;
            resultadoListBox.Items.Add($"O Ano {ano} é bissexto? {(ano % 4 == 0 ? "Sim" : "Não")}.");

            ano = 2022;
            resultadoListBox.Items.Add($"O Ano {ano} é bissexto? {(DateTime.IsLeapYear(ano) ? "Sim" : "Não")}.");

        }

        private void exibirOperadores()
        {
            // || == or
            // && == e
            // != negação
            // ! Negação 
            resultadoListBox.Items.Add("_w < _x || _y == 16: " + (_x < _w || _y == 16));
            resultadoListBox.Items.Add("_w == _x && _z != _x : " + (_x == _w && _z != _x));
            resultadoListBox.Items.Add("!(_y > _w) : " + (!(_y > _z)));
        }

        private void ternariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            precedencia();
        }
    }
}
