using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickUpFactory : MonoBehaviour
{
    [SerializeField] private GameObject buffPickUp;
    public GameObject GetNewPickUP()
    {
        GameObject Instance = Instantiate(buffPickUp);
        return Instance;

    }
}
