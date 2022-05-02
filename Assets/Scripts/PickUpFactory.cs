using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickUpFactory : MonoBehaviour
{
    [SerializeField] private PickUps buffPickUp;
    [SerializeField] private PickUps debuffPickUp;

    public PickUps Create(uint poder)
    {
        switch (poder)
        {
            case 100:
                return Instantiate(buffPickUp);
            case 50:
                return Instantiate(debuffPickUp);
            default:
                throw new ArgumentOutOfRangeException($"El pickUp con el poder en {poder} no existe");
        }
        
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
