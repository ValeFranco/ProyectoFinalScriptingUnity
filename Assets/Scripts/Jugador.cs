using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "Crear Jugador", menuName = "Jugador")]
public class Jugador : ScriptableObject
{
    public uint basepoder;
    internal uint poder;
    public string nombre;
    public int vidas;
    public bool muerto;
    public GameObject gameOver;

    private TorreJugador torreJugador;

    public Jugador(uint poder, string nombre)
    {
        Poder = poder;
        Nombre = nombre;
        Vidas = 3;
    }
    public uint Poder
    {
        get => poder;
        set
        {
            if (value > 0)
            {
                poder = value;
            }

            else
            {
                throw new UnityException("el poder inicial del usuario no puede ser cero");
            }


        }
    }
    public string Nombre
    {
        get => nombre; set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new UnityException("el nombre no puede tener espacios en blanco  ");
            }
            else
            {
                nombre = value;
            }
        }
    }

    public int Vidas { get => vidas; private set => vidas = value; }

}
