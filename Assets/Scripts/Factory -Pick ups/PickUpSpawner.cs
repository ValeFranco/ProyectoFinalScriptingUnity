using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpSpawner : MonoBehaviour   //cliente
{
    [SerializeField] FactoryFacade factory;

    private GameObject lastPickUp;
    int numero = Random.Range(0, 2);
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetPickUp(PickUpType.Buff);
        }          
        else if (Input.GetKeyDown(KeyCode.D))
        {
            GetPickUp(PickUpType.Debuff);
        }
    }
    private void Start()
    {
        
    }

    private void GetPickUp(PickUpType pickUpType)
    {
        if (lastPickUp != null)
            Destroy(lastPickUp);

        lastPickUp = factory?.CrearNuevoPickUp(pickUpType);
        Vector3 posicionDestino = new Vector3(-5, 2, 0);
        lastPickUp.transform.position = posicionDestino;
    }

}
