using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestResultadosCombate
{
    

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestResultadosCombateWithEnumeratorPasses()
    {

        
        Jugador jugador3 = new Jugador(15, "Pruebita");
        TorreJugador torreJugador = new TorreJugador(3, jugador3);

        //Atacable empate = new Atacable(falso, 18);
        // Atacable victoria = new Atacable(falso, 3);
        //Atacable derrota = new Atacable(falso, 33);
        //TorreEnemigo torreEnemigo = new TorreEnemigo(4, empate);
        //torreEnemigo.listaAtacable.Add(victoria);
        //torreEnemigo.listaAtacable.Add(derrota);

        yield return new WaitForSeconds(10);
        //Assert.IsFalse(jugador3.Atacar(derrota, torreEnemigo));
        //Assert.IsTrue(jugador3.Atacar(victoria, torreEnemigo));
        //Assert.IsFalse(jugador3.Atacar(empate, torreEnemigo));
    }


}

