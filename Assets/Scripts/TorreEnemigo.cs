using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreEnemigo : Torre
{
    Atacable atacable;
    public List<Enemigo> listaEnemigos;
    bool destruible;

    public TorreEnemigo(uint altura, Enemigo enemigo) : base(altura)
    {
        this.Altura = altura;
        listaEnemigos = new List<Enemigo>((int)altura);
        listaEnemigos.Add(enemigo);
        destruible = false;
    }
    internal void ReducirAltura(Enemigo target)
    {
        listaEnemigos.Remove(target);
        altura--;
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
