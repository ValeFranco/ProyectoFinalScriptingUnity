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
        
        Jugador jugador2 = new Jugador(15, "Pruebita");
        TorreJugador torreJugador = new TorreJugador(3, jugador2);

        ControlJugador jugador = new ControlJugador();

        Enemigo enemigo = new Enemigo(33);
       
        //TorreEnemigo torreEnemigo = new TorreEnemigo(4, enemigo);

        jugador.AtacarEnemigo(enemigo);

        yield return new WaitForSeconds(12);
        Assert.AreEqual(2, jugador.Jugador.Vidas);
    }
}
