using NUnit.Framework;
using WebApiJuros1.Models;
using WebApiJuros1.Controllers;
using WebApiJuros1.Repositorio;
using WebApiJuros1.Class;
using Microsoft.AspNetCore.Http.Connections;
using System;

namespace NUnitTestJuros
{
    public class Tests
    {
        private readonly IcalculajurosRepositorio _calculajurosRepositorio;
        private readonly ItaxajurosRepositorio _taxajurosRepositorio;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            taxajuros TAXA = new taxajuros();
            Assert.AreEqual(TAXA, 0.01);
        }
        public void Test2()
        {
            WebApiJuros1.Controllers.taxajurosController taxajuros = new taxajurosController(_taxajurosRepositorio);
            var taxa = taxajuros.Get();
            double resultado = Convert.ToDouble(100) * Math.Pow(Convert.ToDouble(1 + Validacoes.ResultadoJuros), Convert.ToDouble(5));
            Assert.AreEqual(resultado, 105.10);
        }

       
    }
}