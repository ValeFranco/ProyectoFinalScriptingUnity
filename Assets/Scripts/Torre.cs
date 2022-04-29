using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre : MonoBehaviour
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
               // throw new Exception("La altura de la torre no puede ser cero");
            }
        }
    }
    public Torre(uint altura)
    {
        this.Altura = altura;
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
