using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace AspNetVS2017.Capitulo01.Repeticao.Testes
{
    [TestClass]
    public class ColecoesTeste
    {
        [TestMethod]
        public void ListTeste()
        {
            List<decimal> inteiros = new List<decimal>();

            inteiros.Add(0.25m);
            inteiros.Add(5);
            inteiros.Add(3);
            inteiros.Add(28);

            foreach (var item in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(item)} : {item}");
            }



            var maisinteiros = new  List<decimal>() {1,3,2,9};
            inteiros.AddRange(maisinteiros);

            foreach (var item in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(item)} : {item}");
            }

            inteiros.Insert(0, 32);
            inteiros.Remove(3);
            inteiros.RemoveAt(0);

            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo = inteiros[inteiros.Count - 1];

            inteiros.RemoveAll(x => x == 3);

        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();
            feriados.Add(new DateTime(2018,12,25),"Natal");
            feriados.Add(new DateTime(2019, 01, 01), "Ano Novo");
            feriados.Add(new DateTime(2019, 01, 25), "Aniversário de São Paulo");

            var feriado = feriados[new DateTime(2018, 12, 25)];

            Console.WriteLine(feriado);

            foreach (var item in feriados)
            {
                Console.WriteLine($"Data do Feriado : {item.Key.ToShortDateString()} Feriado : {item.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(new DateTime(2018, 12, 25)));
            Console.WriteLine(feriados.ContainsValue("Ano Novo"));

        }

        [TestMethod]
        public void StackTeste()
        {
            // LIFO
            // PILHA
            var pilha = new Stack<int>();

            pilha.Push(1);
            pilha.Push(4);
            pilha.Push(7);

            Assert.AreEqual(pilha.Pop(),7);
            Assert.AreEqual(pilha.Peek(),4);

            
            Console.WriteLine($"A pilha esta vária ? {pilha.Count == 0}");
            Console.WriteLine($"Qtde de itens na pilha : {pilha.Count}");
        }

        [TestMethod]
        public void QueueTeste()
        {
            // FIFO
            // Fila
            var fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(2);

            Assert.AreEqual(fila.Dequeue(),1);
            Assert.AreEqual(fila.Peek(), 4);

            Console.WriteLine($"A fila esta vária ? {fila.Count == 0}");
            Console.WriteLine($"Qtde de itens há na fila : {fila.Count}");

        }
    }
}
