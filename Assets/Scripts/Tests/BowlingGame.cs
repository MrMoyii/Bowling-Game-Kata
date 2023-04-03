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
        [Test]
        public void BowlingGameSimplePasses()
        {
            Partidas p = new Partidas();

            p.Partida();

            Assert.IsTrue(true);
        }
    }
}
