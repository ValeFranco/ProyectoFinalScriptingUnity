using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestLimpiarLista
{
    
    [UnityTest]
    public IEnumerator TestLimpiarListaWithEnumeratorPasses()
    {
        
        //Atacable atacable = new Atacable(2);

        Enemigo enemigo = new Enemigo(2);
        Jugador jugador = new Jugador(5, "Juan");
        ControlJugador controlJugador = new ControlJugador();
        //TorreJugador torreJugador = new TorreJugador(3, jugador);

        //TorreEnemigo torreEnemigo = new TorreEnemigo(1, atacable);

        controlJugador.AtacarEnemigo(enemigo);
       

        

        yield return new WaitForSeconds(10);
        
       
    }
}
