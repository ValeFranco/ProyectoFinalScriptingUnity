using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestTorreContieneJugador
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestTorreContineJugador()
    {

        Jugador jugador = new Jugador(5, "Sebastian");
        uint altura = 3;
        TorreJugador torreTest = new TorreJugador(altura, jugador);
        List<Jugador> listaJugadorTest = new List<Jugador>(3);
        listaJugadorTest.Add(jugador);

        Assert.AreEqual(listaJugadorTest, torreTest.listaJugador);

    }
}
