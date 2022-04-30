using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreJugador : Torre
{
    Jugador jugador;
    public List<object> listaJugador;
    public TorreJugador(uint altura, Jugador jugador) : base(altura)
    {
        this.Altura = altura;
        this.jugador = jugador;
        listaJugador = new List<object>((int)altura);
        listaJugador.Add(jugador);
    }
    public Jugador Jugador { get => jugador; set => jugador = value; }
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

            //if (!test.esObstaculo)
            //{
            //    listaJugador.Add(objeto);
            //}
            //else
            //{
            //    //throw new Exception("no se pueden a?adir enemigos a la torre");
            //}

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
