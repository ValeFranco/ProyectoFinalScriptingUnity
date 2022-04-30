using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestTorreTieneNiveles
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestTorreTieneNivelesSimplePasses()
    {
        Jugador Test1Jugador = new Jugador(3, "nombre");
        TorreJugador testTorreJugador;
        var exception = Assert.Throws<System.Exception>(() => testTorreJugador = new TorreJugador(0, Test1Jugador));
        Assert.AreEqual("La altura de la torre no puede ser cero", exception.Message);
    }
    
}
