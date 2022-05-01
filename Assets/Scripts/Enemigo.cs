using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Atacable
{
    public TorreEnemigo torreEnemigo;
    public Enemigo(uint poder, TorreEnemigo torreEnemigo) : base(poder)
    {
        this.torreEnemigo = torreEnemigo;

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
