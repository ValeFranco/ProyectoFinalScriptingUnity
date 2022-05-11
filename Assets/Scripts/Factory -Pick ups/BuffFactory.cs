using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BuffFactory : MonoBehaviour
{
    [SerializeField] private GameObject buffPickUp;
    [SerializeField] private GameObject debuffPickUp;

    public GameObject CrearNuevoPickUp()
    {
        GameObject instance = Instantiate(buffPickUp);
        return instance;
    }
  
}
