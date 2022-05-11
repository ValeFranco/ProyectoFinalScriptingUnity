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
        Jugador jugador = new Jugador(15, "Pruebita");
       // TorreJugador torreJugador = new TorreJugador(3, jugador);

        ControlJugador controlJugador = new ControlJugador();

        Enemigo enemigo = new Enemigo(3);
        
        //TorreEnemigo torreEnemigo = new TorreEnemigo(4, enemigo);

        controlJugador.AtacarEnemigo(enemigo);

        //Use the Assert class to test conditions.
        //Use yield to skip a frame.
        yield return new WaitForSeconds(10);

        Assert.AreEqual(18, controlJugador.jugador.Poder);
    }
    
}
