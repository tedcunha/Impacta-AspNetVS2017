using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorio.SistemaDeArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorio.SistemaDeArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio _repositorio = new ModeloRepositorio();

        [TestMethod()]
        public void SelecionarPorMarcaTest()
        {
            var modelos = _repositorio.SelecionarPorMarca(1);

            foreach (var item in modelos)
            {
                Console.WriteLine($"Marca : {item.Descricao} - {item.Marca.Nome}");
            }


            Assert.AreEqual(modelos[0].Id, 1);
            Assert.IsTrue(modelos[0].Descricao == "Argo");
            Assert.AreEqual(modelos[0].Marca.Nome , "Fiat");
        }

        [TestMethod()]
        [DataRow(1)]
        [DataRow(-1)]
        public void SelecionarPorIdTeste(int modeloId)
        {
            var modelo = _repositorio.Selecionar(modeloId);
            if (modeloId > 0)
            {
                Assert.AreEqual(modelo.Id, modeloId);
                Assert.AreEqual(modelo.Descricao, "Argo");
            }
            else
            {
                Assert.IsNull(modelo);
            }
        }
    }
}