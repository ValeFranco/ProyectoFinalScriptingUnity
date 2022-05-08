using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreEnemigo : MonoBehaviour
{

    public List<Pisos> listaPisos;

    public List<Pisos> ListaPisos { get => listaPisos; set => listaPisos = value; }

    internal void RemoverPiso(int altura)
    {
        Destroy(ListaPisos[altura]);
        ListaPisos.RemoveAt(altura);

    }

    //public uint altura;

    //public uint Altura { get => altura; private set => altura = value; }

    //public uint Altura
    //{
    //    get => altura;

    //    private set
    //    {
    //        if (value != 0)
    //        {
    //            altura = value;
    //        }
    //        else
    //        {
    //            throw new UnityException("La altura de la torre no puede ser cero");
    //        }
    //    }
    //}

    //public TorreEnemigo(uint altura, Enemigo enemigo)
    //{
    //    this.Altura= altura;
    //    listaEnemigos = new List<Enemigo>((int)altura);
    //    listaEnemigos.Add(enemigo);

    //}
}
