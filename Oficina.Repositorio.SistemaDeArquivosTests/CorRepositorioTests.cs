using Oficina.Repositorio.SistemaDeArquivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Oficina.Repositorio.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        [TestMethod()]
        public void SelecionarTodosTest()
        {
            var corRepositorio = new CorRepositorio();
            var cores = corRepositorio.Selecionar();
            foreach (var item in cores)
            {
                Console.WriteLine($"{item.Id} - {item.Descricao}");
            }

        }

        [TestMethod()]
        [DataRow(3)]
        [DataRow(-1)]
        public void SelecionarCorIDTest(int corID)
        {
            var corRepositorio = new CorRepositorio();
            var cor = corRepositorio.Selecionar(corID);

            //if (corID > 0)
            //{
            //    Assert.IsTrue(cor.Id == 1);
            //}
            //else
            //{
            //    Assert.IsNull(cor);
            //}

            if (cor != null)
            {
                Console.WriteLine($"{cor.Id} - {cor.Descricao}");
            }
            else
            {
                Console.WriteLine($"Não há dados para mostrar");
            }
        }
    }
}