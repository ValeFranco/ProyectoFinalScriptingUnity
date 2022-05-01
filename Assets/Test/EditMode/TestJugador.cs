using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestJugador
{
    [Test]
    public void TestJugadorPoderNoEsCero()
    {
        Jugador testJugador;
        var exception = Assert.Throws<UnityException>(() => testJugador = new Jugador(0, "carlos"));
        Assert.AreEqual("el poder inicial del usuario no puede ser cero", exception.Message);

    }

}
