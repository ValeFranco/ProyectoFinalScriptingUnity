using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreJugador : MonoBehaviour
{ 
    int altura;
    Jugador jugador;
    
    public GameObject prefabPisos;

    [SerializeField]
    public List<PisosJugador> listaPisosJugador;

    public float deltaPosicion;
    

    public TorreJugador(int altura, Jugador jugador)
    {
        this.Altura = altura;
        this.jugador = jugador;
       
    }


    public Jugador Jugador { get => jugador; set => jugador = value; }

    internal int Altura
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

    public void AumentarAltura()
    {
        //PisosJugador nuevoPiso = new PisosJugador();

        //listaPisosJugador.Add(nuevoPiso);
        Vector3 posicionDestino = listaPisosJugador[altura].gameObject.transform.position;
        Vector2 posiciónPisoNuevo = new Vector2();

        
       
        posiciónPisoNuevo.y = listaPisosJugador[altura].transform.position.y + deltaPosicion;
       
        
        Instantiate(prefabPisos, posiciónPisoNuevo, transform.rotation);
        altura++;

    }
   

    //-1.74
    //-4.590354 otra monda
    //suma:2.85


}
