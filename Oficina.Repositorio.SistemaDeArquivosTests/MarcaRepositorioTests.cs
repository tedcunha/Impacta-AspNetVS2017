using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorio.SistemaDeArquivos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorio.SistemaDeArquivos.Dados.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        MarcaRepositorio _marcarepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void SelecionarTodosTest()
        {
            var marcas = _marcarepositorio.SelecionarTodos();
            foreach (var marca in marcas)
            {
                Console.WriteLine($"{marca.Id} - {marca.Nome}");
            }


        }

        [TestMethod()]
        [DataRow(3)]
        [DataRow(-1)]
        public void SelecionarMarcaIDTest(int marcaID)
        {
            var marcas = _marcarepositorio.Selecionar(marcaID);

            if (marcas != null)
            {
                Console.WriteLine($"{marcas.Id} - {marcas.Nome}");
            }
            else
            {
                Console.WriteLine($"Não há dados para mostrar");
            }

            //if (marcaID > 0)
            //{
            //    Assert.AreEqual(marcas.Nome, "Fiat");
            //}
            //else
            //{
            //    Assert.IsNull(marcas);
            //}

        }


    }
}