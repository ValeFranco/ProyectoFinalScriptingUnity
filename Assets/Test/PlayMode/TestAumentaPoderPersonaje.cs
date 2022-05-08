using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestAumentaPoderPersonaje
{
    [UnityTest]
    public IEnumerator TestAumentaPoderPersonajeWithEnumeratorPasses()
    {
        Jugador jugador = ScriptableObject.CreateInstance<Jugador>();
        ControlJugador controlJugador = new ControlJugador
        {
            jugador = jugador
        };
        controlJugador.jugador.basepoder = 13;

        //HACER LO MISMO CON EL ENEMIGO == VELOR DE PODER MENOR 10
        Enemigo enemigo = ScriptableObject.CreateInstance<Enemigo>();
        ControlEnemigo controlEnemigo = new ControlEnemigo();
        controlEnemigo.enemigo = enemigo;
        controlEnemigo.enemigo.poder = 3;
        
        //ENFRENTAS AL JUGADOR Y A AL ENEMIGO
        controlJugador.AtacarEnemigo(enemigo);


    
        
        yield return null;

        Assert.AreEqual(16, controlJugador.jugador.poder);
                      //VALOR ESPERADO, VALOR que tienes en realidad
     //alo   
    }
}
