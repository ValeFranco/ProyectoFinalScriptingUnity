using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreEnemigo : Torre
{
    Atacable atacable;
    public List<Atacable> listaAtacable;
    bool destruible;
    public TorreEnemigo(uint altura, Atacable atacable) : base(altura)
    {
        this.Altura = altura;
        this.atacable = atacable;
        listaAtacable = new List<Atacable>((int)altura);
        listaAtacable.Add(atacable);
        destruible = false;
    }
    internal void ReducirAltura(Atacable target)
    {
        listaAtacable.Remove(target);
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
