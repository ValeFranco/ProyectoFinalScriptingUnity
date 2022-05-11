using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField] private PickUpFactory pickUpFactory;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            pickUpFactory.Create(100);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            pickUpFactory.Create(50);
        }
    }
}
