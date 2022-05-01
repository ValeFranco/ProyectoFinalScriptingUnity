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

        //Atacable derrota = new Atacable(falso, 33);
        //TorreEnemigo torreEnemigo = new TorreEnemigo(4, derrota);

        //torreJugador.Atacar(derrota, torreEnemigo);

        yield return new WaitForSeconds(12);
        Assert.AreEqual(2, torreJugador.Jugador.Vidas);
    }
}
