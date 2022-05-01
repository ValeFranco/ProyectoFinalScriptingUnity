using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Atacable
{

    TorreJugador torreJugador;


    public Pickup(uint poder, TorreJugador torre) : base (poder)
    {
        torreJugador = torre;

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
