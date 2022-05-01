using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Torre : ScriptableObject
{
    public uint altura;
    internal uint Altura
    {
        get => altura; set
        {
            if (value != 0)
            {
                altura = value;
            }
            else
            { 
               throw new Exception("La altura de la torre no puede ser cero");
            }
        }
    }
    public Torre(uint altura)
    {
        this.Altura = altura;
    }
  
}
