using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "Crear Jugador", menuName = "Jugador")]
public class Jugador : ScriptableObject
{
    public uint poder;
    public string nombre;
    public byte vidas;
    public bool muerto;
    public GameObject gameOver;

    private TorreJugador torreJugador;


    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Jugador(uint poder, string nombre)
    {
        Poder = poder;
        Nombre = nombre;
        vidas = 3;
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
            
               // throw new Exception("el poder inicial del usuario no puede ser cero");
        }
    }
    public string Nombre
    {
        get => nombre; set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                //throw new Exception("el nombre no puede tener espacios en blanco  ");
            }
            else
            {
                nombre = value;
            }
        }
    }
   
    //programar funcion atacar
    //
    public bool Atacar(Enemigo enemigo)
    {
        bool victoria = false;
        if (enemigo.poder > poder)
        {
            victoria = false;

            Salud();

            return victoria;
        }
        if (enemigo.poder == poder)
        {
            victoria = false;
            Salud();
            return victoria;
        }
        else if (enemigo.poder < poder)
        {
            victoria = true;
            poder += enemigo.poder;
            enemigo.torreEnemigo.ReducirAltura(enemigo);
            torreJugador.AumentarAltura();

            if (enemigo.torreEnemigo.altura == 0 || enemigo.torreEnemigo.listaAtacable.Count == 0)
            {
                enemigo.torreEnemigo = null;
            }
            return victoria;
        }

        return victoria;
    }

    public bool Atacar(Pickup target)
    {
        bool victoria;
        poder += target.poder;
        victoria = true;
        return victoria;
    }

    /*
    public bool Atacar(Atacable target)
    {
        bool victoria = false;

        if (target is Pickup)
        {
            poder += target.poder;
            victoria = true;
            return victoria;
        }
        else if (target is Enemigo)
        {
            Enemigo enemigo = target as Enemigo;

            if (target.poder > poder)
            {
                victoria = false;

                Salud();

                return victoria;
            }
            if (target.poder == poder)
            {
                victoria = false;
                Salud();
                return victoria;
            }
            else if (target.poder < poder)
            {
                victoria = true;
                poder += target.poder;
                enemigo.torreEnemigo.ReducirAltura(target);
                torreJugador.AumentarAltura();

                if (enemigo.torreEnemigo.altura == 0 || enemigo.torreEnemigo.listaAtacable.Count == 0)
                {
                    enemigo.torreEnemigo = null;
                }
                return victoria;
            }

         
        }
        return victoria;

    }
    */


    public void Salud()
    {
        vidas--;
        if ( vidas == 0)
        {
            Iniciar();
           // gameOver.SetActive(true);
          
        }
    }

  
    //movimiento
    //morision
}
