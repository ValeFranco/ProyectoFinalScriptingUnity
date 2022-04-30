using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestCombate
{
    
    [UnityTest]
    public IEnumerator TestCombateWithEnumeratorPasses()
    {
        ControladorJuego controladorJuego = new ControladorJuego();

        List<Torre> torres = new List<Torre>(2);

        //Atacable atacable1 = new Atacable(false, 2);
        //Atacable atacable2 = new Atacable(false, 3);
        //Atacable atacable3 = new Atacable(false, 1);
        //Atacable atacable4 = new Atacable(false, 4);

        //TorreEnemigo torreEnemigo1 = new TorreEnemigo(2, atacable1);
        //TorreEnemigo torreEnemigo2 = new TorreEnemigo(2, atacable2);

        //torreEnemigo1.listaAtacable.Add(atacable3);
        //torreEnemigo2.listaAtacable.Add(atacable4);

        Jugador jugador = new Jugador(6, "Valentina");
        TorreJugador torreJugador = new TorreJugador(3, jugador);
        controladorJuego.torreJugador = torreJugador;

        //juego.listaTorres.Add(torreEnemigo1);
        //juego.listaTorres.Add(torreEnemigo2);


        //jugador.Atacar(atacable1, torreEnemigo1);
        //jugador.Atacar(atacable3, torreEnemigo1);

        //juego.LimpiarLista();

        //jugador.Atacar(atacable2, torreEnemigo2);
        //jugador.Atacar(atacable4, torreEnemigo2);

        string mensaje = controladorJuego.LimpiarLista();

        yield return new WaitForSeconds(10);
        Assert.AreEqual("Pasaste de nivel", mensaje);
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        
    }
}
