using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestUltimaTorre
{
    
    [UnityTest]
    public IEnumerator TestUltimaTorreWithEnumeratorPasses()
    {
        List<Torre> torreEsperada = new List<Torre>(0);
        //Atacable atacable = new Atacable(false, 2);
        Enemigo enemigo = new Enemigo(2);

        ControlJugador controljugador = new ControlJugador();
        ControladorJuego controladorJuego = new ControladorJuego();

        Jugador jugador = new Jugador(5, "Juan");
        TorreJugador torreJugador = new TorreJugador(3, jugador);

        TorreEnemigo torreEnemigo = new TorreEnemigo(1, enemigo);

        //torreJugador.Atacar(atacable, torreEnemigo);
        controljugador.AtacarEnemigo(enemigo);

        controladorJuego.LimpiarLista();

        
        yield return null;
        Assert.AreEqual(torreEsperada, controladorJuego.listaTorresEnemigo);
    }
}
