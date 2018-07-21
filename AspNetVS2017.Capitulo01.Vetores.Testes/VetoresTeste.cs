using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AspNetVS2017.Capitulo01.Vetores.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void InicializacaoTeste()
        {
            string[] strings = new string[10];
            strings[0] = "Vitor";

            var decimais = new decimal[] {0.5m,1,1.59m};

            int[] inteiros = { 1, 58, 10, 0 };

            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"Posição : {inteiro}");
            }

            Console.WriteLine($"Tamanho do Vetor : {inteiros.Length}");

            var soma = inteiros.Where(x => x > 1).Sum();
            Console.WriteLine($"Total : {soma}");
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m };
            Array.Resize(ref decimais, 5);
            decimais[4] = 2.1m;
        }

        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m, 0.4m };
            Array.Resize(ref decimais, 5);

            decimais[4] = 2.1m;
            Array.Sort(decimais);

            Assert.AreEqual(decimais[0],0.4m);
        }

        [TestMethod]
        public void ParamsTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 1.59m, 0.4m };
            var media = CalcularMedia(decimais);

            Console.WriteLine($"Soma   : {decimais.Sum()}");
            Console.WriteLine($"Média  : {media}");

            var media2 = CalcularMedia(2,3.5m,8);
            Console.WriteLine($"Média2 : {media2}");
        }

        //public decimal CalcularMedia(decimal dec1, decimal dec2)
        //{
        //    return ((dec1 + dec2) / 2);
        //}

        public decimal CalcularMedia(params decimal[] valores)
        {
            return (valores.Sum() / valores.Length);
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste()
        {
            var nome = "Vitor";

            foreach (var caractere in nome)
            {
                Console.WriteLine(caractere);
            }

            Assert.AreEqual(nome.First(), 'V');

        }

    }
}
