using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crear PickUp", menuName = "PickUp")]
public class Pickup : ScriptableObject
{
    TorreJugador torreJugador;
    public  uint poder;
    public Pickup(uint poder, TorreJugador torre) 
    {
        this.TorreJugador = torre;
        this.Poder = poder;
    }

    public TorreJugador TorreJugador { get => torreJugador;  private set => torreJugador = value; }
    public uint Poder { get => poder; private set => poder = value; }
}
