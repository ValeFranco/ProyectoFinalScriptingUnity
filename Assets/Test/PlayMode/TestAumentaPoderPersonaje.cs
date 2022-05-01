using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestAumentaPoderPersonaje
{
    [UnityTest]
    public IEnumerator TestAumentaPoderPersonajeWithEnumeratorPasses()
    {
        Jugador jugador = new Jugador(15, "Pruebita");
        TorreJugador torreJugador = new TorreJugador(3, jugador);

        Atacable victoria = new Atacable(false, 3);
        TorreEnemigo torreEnemigo = new TorreEnemigo(4, victoria);

        jugador.Atacar(victoria, torreEnemigo);

        //Use the Assert class to test conditions.
        //Use yield to skip a frame.
       yield return new WaitForSeconds(10);

        Assert.AreEqual(18, torreJugador.Jugador.poder);
    }
}
