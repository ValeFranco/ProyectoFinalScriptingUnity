using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crear TorreEnemigo", menuName = "TorreEnemigo")]
public class TorreEnemigo :ScriptableObject
{
    //Atacable atacable;
    public List<Enemigo> listaEnemigos;

    public uint altura;

    public uint Altura { get => altura; private set => altura = value; }

    public TorreEnemigo(uint altura, Enemigo enemigo)
    {
        this.Altura= altura;
        listaEnemigos = new List<Enemigo>((int)altura);
        listaEnemigos.Add(enemigo);
        
    }
    internal void ReducirAltura(Enemigo target)
    {
        listaEnemigos.Remove(target);
        Altura--;
    }
}
