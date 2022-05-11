using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpSpawner : MonoBehaviour
    //cliente
{
    [SerializeField] FactoryFacade factory;
    private GameObject lastPickUp;
    int numero;
    private void Start()
    {
         numero = Random.Range(0, 2);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(numero == 0)
            {
                GetPickUp(PickUpType.buff);
            }
            else
            {
                GetPickUp(PickUpType.deBuff);
            }
        }

    }
   
    private void GetPickUp(PickUpType pickUpType)
    {
        if (lastPickUp != null)
            Destroy(lastPickUp);

        lastPickUp = factory?.GetNewPickUp(pickUpType);
        Vector3 posicionDestino = new Vector3(-5.5f, 0.57f, 0);
        lastPickUp.transform.position = posicionDestino;
    }

}
