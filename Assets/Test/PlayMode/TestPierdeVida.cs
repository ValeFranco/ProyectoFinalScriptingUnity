using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPierdeVida
{
   
    [UnityTest]
    public IEnumerator TestPierdeVidaWithEnumeratorPasses()
    {
        Jugador jugador = ScriptableObject.CreateInstance<Jugador>();
        ControlJugador controlJugador = new ControlJugador();
        controlJugador.jugador = jugador;
        controlJugador.jugador.Poder = 10;

        Enemigo enemigo = ScriptableObject.CreateInstance<Enemigo>();
        ControlEnemigo controlEnemigo = new ControlEnemigo();
        controlEnemigo.enemigo = enemigo;
        controlEnemigo.enemigo.poder = 13;

        controlJugador.AtacarEnemigo(enemigo);

        yield return new WaitForSeconds(10);
        Assert.AreEqual(2, controlJugador.jugador.vidas);


    }
}
