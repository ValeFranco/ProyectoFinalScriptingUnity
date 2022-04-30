using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestGanaContraObstaculo
{
    [UnityTest]
    public IEnumerator TestGanaContraObstaculoWithEnumeratorPasses()
    {
        Jugador jugador4 = new Jugador(15, "Pruebita");
        TorreJugador torreJugador = new TorreJugador(3, jugador4);

        Atacable obstaculo = new Atacable(true, 3);
        TorreEnemigo torreEnemigo = new TorreEnemigo(4, obstaculo);

        jugador4.Atacar(obstaculo, torreEnemigo);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(10);

        Assert.AreEqual(18, torreJugador.Jugador.poder);
    }
    
}
