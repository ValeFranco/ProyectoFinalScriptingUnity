using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacable : MonoBehaviour
{
    internal uint poder;
    public Atacable(uint poder)
    {
        
        Poder = poder;
    }

    public uint Poder
    {
        get => poder; set

        {
            if (value > 0)
                poder = value;
            else
            {
                // throw new Exception("el poder debe ser mayor a cero");
            }

        }
    }

}
