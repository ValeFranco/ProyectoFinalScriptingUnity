using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreJugador : MonoBehaviour
{ uint altura;
    Jugador jugador;
    public List<object> listaJugador;
    public TorreJugador(uint altura, Jugador jugador)
    {
        this.Altura = altura;
        this.jugador = jugador;
        listaJugador = new List<object>((int)altura);
        listaJugador.Add(jugador);
    }


    public Jugador Jugador { get => jugador; set => jugador = value; }

    internal uint Altura
    {
        get => altura; set
        {
            if (value != 0)
            {
                altura = value;
            }
            else
            {
              throw new UnityException("La altura de la torre no puede ser cero");
            }
        }
    }
    
    internal void AumentarAltura()
    {
        List<object> listaNueva = new List<object>(((int)Altura) + 1);
        listaNueva.Add(jugador);

        listaJugador = listaNueva;
        Altura++;
    }



    public void AnadirATorre(object objeto)
    {
        if (objeto is Jugador)
        {
            listaJugador.Add(objeto);
        }
        else if (objeto is Atacable)
        {
            Atacable test = objeto as Atacable;

            if (test is Pickup)
            {
                listaJugador.Add(test);
            }
            else
            {
               
            }

        }
    }
  
}
