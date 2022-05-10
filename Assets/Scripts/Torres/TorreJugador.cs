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

        Vector2 posiciónPisoNuevo = new Vector2();
        for(int i =0; i<listaPisosJugador.Count; i++)
        {
            posiciónPisoNuevo.y = listaPisosJugador[0].transform.position.y + listaPisosJugador[altura].transform.position.y;
        }
        
        prefabPisos = GameObject.Instantiate(prefabPisos, posiciónPisoNuevo, transform.rotation);
        altura++;

        

    }
   

    //-1.74
    //-4.590354 otra monda
    //suma:2.85


}
