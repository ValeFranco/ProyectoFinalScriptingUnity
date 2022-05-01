using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[CreateAssetMenu(fileName = "Crear Jugador", menuName = "Jugador")]
public class Jugador : ScriptableObject
{
    public uint poder;
    public string nombre;
    public int vidas;
    public bool muerto;
    public GameObject gameOver;

    private TorreJugador torreJugador;


    // Start is called before the first frame update
    void Start()
    {
        //gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

    public int Vidas { get => vidas; private set => vidas = value; }

    //programar funcion atacar


    //public bool AtacarEnemigo(Enemigo enemigo)
    //{
    //    bool victoria = false;
    //    if (enemigo.Poder > poder)
    //    {
    //        victoria = false;

    //        Salud();

    //        return victoria;
    //    }
    //    if (enemigo.Poder == poder)
    //    {
    //        victoria = false;
    //        Salud();
    //        return victoria;
    //    }
    //    else if (enemigo.Poder < poder)
    //    {
    //        victoria = true;
    //        poder += enemigo.Poder;
    //        enemigo.TorreEnemigo.ReducirAltura(enemigo);
    //        torreJugador.AumentarAltura();

    //        if (enemigo.TorreEnemigo.altura == 0 || enemigo.TorreEnemigo.listaEnemigos.Count == 0)
    //        {
    //            enemigo.torreEnemigo = null;
    //        }
    //        return victoria;
    //    }

    //    return victoria;
    //}

    //public bool AtacarPickUP(Pickup target)
    //{
    //    bool victoria;
    //    poder += target.Poder;
    //    victoria = true;
    //    return victoria;
    //}


    //public void Salud()
    //{
    //    Vidas--;
    //    if ( Vidas == 0)
    //    {
    //        //Iniciar();
    //       // gameOver.SetActive(true);
          
    //    }
    //}

  
    //movimiento
    //morision
}
