using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen3EV_NS;
using System;

namespace UnitTestProject1JOB2021
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1JOB2021()
        {
            List<double> notas = new List<double>();
            
            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;
            int suspensosEsperados = 3;
            int aprobadosEsperados = 1;
            int notablesEsperados = 2;
            int sobresalientesEesperados = 1;

            EstadisticaNotasJOB2021 estadisticaNotas = new EstadisticaNotasJOB2021(notas);

            int suspensos = estadisticaNotas.SuspensosJOB2021;
            int aprobados = estadisticaNotas.Aprobadosjob2021;
            int notables = estadisticaNotas.NotablesJOB2021;
            int sobresalientes = estadisticaNotas.SobresalientesJOB2021;
            double media = estadisticaNotas.MediaJOB2021;

            Assert.AreEqual(suspensos, suspensosEsperados, 0.001, "El resultado no es el esperado");
            Assert.AreEqual(aprobados, aprobadosEsperados, 0.001, "El resultado no es el esperado");
            Assert.AreEqual(notables, notablesEsperados, 0.001, "El resultado no es el esperado");
            Assert.AreEqual(sobresalientes, sobresalientesEesperados, 0.001, "El resultado no es el esperado");
            Assert.AreEqual(media, mediaEsperada, 0.001, "El resultado no es el esperado");
        }

        [TestMethod]
        public void PruebaErrorListaVaciaJOB2021()
        {
            List<double> notas = new List<double>();

            try
            {
            EstadisticaNotasJOB2021 estadisticaNotas = new EstadisticaNotasJOB2021(notas);
            }
            catch(SystemException e)
            {
                StringAssert.Contains(e.Message, EstadisticaNotasJOB2021.listaVacia);
                return;
            }
            Assert.Fail();
        }

        [TestMethod]
        public void PruebaErrorNotasFueraRangoJOB2021()
        {
            List<double> notas = new List<double>();
            notas.Add(6);
            notas.Add(12);
            notas.Add(-1);
            notas.Add(8);

            try
            {
                EstadisticaNotasJOB2021 estadisticaNotas = new EstadisticaNotasJOB2021(notas);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, EstadisticaNotasJOB2021.notasFueraRango);
                return;
            }
            Assert.Fail();
        }
    }
}
