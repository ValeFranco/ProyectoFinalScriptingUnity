using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestUltimaTorre
{
    /
    [UnityTest]
    public IEnumerator TestUltimaTorreWithEnumeratorPasses()
    {
        List<Torre> torreEsperada = new List<Torre>(0);
        //Atacable atacable = new Atacable(false, 2);

        ControladorJuego controladorJuego = new ControladorJuego();
        Jugador jugador = new Jugador(5, "Juan");
        TorreJugador torreJugador = new TorreJugador(3, jugador);

        //TorreEnemigo torreEnemigo = new TorreEnemigo(1, atacable);

        //torreJugador.Atacar(atacable, torreEnemigo);

        controladorJuego.LimpiarLista();

        //Assert.AreEqual(torreEsperada, controladorjuego.listaTorres);
        yield return null;
    }
}
