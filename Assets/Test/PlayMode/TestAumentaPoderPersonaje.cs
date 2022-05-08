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
        ControlJugador controlJugador = new ControlJugador();
        controlJugador.jugador = jugador;
        controlJugador.jugador.basepoder = 13;

       //HACER LO MISMO CON EL ENEMIGO == VELOR DE PODER MENOR 10

        //ENFRENTAS AL JUGADOR Y A AL ENEMIGO
        
    

        

      
        yield return new WaitForSeconds(10);

        //Assert.AreEqual(23, /*controlJugador.Jugador.poder*/);
                      //VALOR ESPERADO, VALOR que tienes en realidad
    }
}
