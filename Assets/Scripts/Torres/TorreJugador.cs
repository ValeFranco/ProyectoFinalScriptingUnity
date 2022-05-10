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

    private void Start()
    {
        altura = listaPisosJugador.Count - 1;
    }

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
        Vector3 posicionDestino = listaPisosJugador[altura].gameObject.transform.position + Vector3.up * deltaPosicion;
        GameObject nuevoPiso = Instantiate(prefabPisos, posicionDestino, transform.rotation, transform);

        listaPisosJugador.Add(nuevoPiso.GetComponent<PisosJugador>());
        altura++;
        listaPisosJugador[altura].altura = altura;
    }
   

    //-1.74
    //-4.590354 otra monda
    //suma:2.85


}
