using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Tests;

namespace Tests
{
    public class BowlingGame
    {
        Partidas p;

        [SetUp] public void Setup()
        {
            p = new Partidas();
        }

        [Test]
        public void TestPartida()
        {
            //When
            int puntajePartida = p.Partida();

            //Then
            Assert.LessOrEqual(puntajePartida, 300);
        }
        [Test]
        public void TestLanzamiento()
        {
            //When
            int cantBolos = p.Lanzamiento(10);

            //Then
            Assert.LessOrEqual(cantBolos, 10);
            Assert.GreaterOrEqual(cantBolos, 0);
        }
    }
}
