using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestResultadosCombate
{
    [UnityTest]
    public IEnumerator TestResultadosCombateWithEnumeratorPasses()
    {

        ControlJugador controlJugador = new ControlJugador();
        Jugador jugador3 = new Jugador(15, "Pruebita");
        TorreJugador torreJugador = new TorreJugador(3, jugador3);

        Enemigo empate = new Enemigo(18);
        Enemigo victoria = new Enemigo(3);
        Enemigo derrota = new Enemigo(33);

        //TorreEnemigo torreEnemigo = new TorreEnemigo(4, empate);
        //torreEnemigo.listaEnemigos.Add(victoria);
        //torreEnemigo.listaEnemigos.Add(derrota);

        yield return new WaitForSeconds(10);

        Assert.IsFalse(controlJugador.AtacarEnemigo(empate));
        Assert.IsTrue(controlJugador.AtacarEnemigo(victoria));
        Assert.IsFalse(controlJugador.AtacarEnemigo(derrota));
    }


}

