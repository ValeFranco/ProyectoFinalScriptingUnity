using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpSpawner : MonoBehaviour
    //cliente
{
    [SerializeField] FactoryFacade factory;

    //[SerializeField] private PickUpFactory pickUpFactory;
    //[SerializeField] private DeBuffFactory pickUpFactoryDeBuff;

    private GameObject lastPickUp;
   // int numero = Random.Range(0, 2);
    
    private void Update()
    {
        //if (Input.GetKey(KeyCode.Alpha1))
        //{
        //    pickUpFactory.Create(100);
        //}
        //else if (Input.GetKey(KeyCode.Alpha2))
        //{
        //    pickUpFactory.Create(50);
        //}
        

        if (Input.GetKeyDown(KeyCode.C))
            GetPickUp(PickUpType.buff);
        else if (Input.GetKeyDown(KeyCode.D))
        {
            GetPickUp(PickUpType.deBuff);
        }

    }
    private void Start()
    {
        
    }

    private void GetPickUp(PickUpType pickUpType)
    {
        if (lastPickUp != null)
            Destroy(lastPickUp);

        lastPickUp = factory?.GetNewPickUp(pickUpType);
        Vector3 posicionDestino = new Vector3(-5, 2, 0);
        lastPickUp.transform.position = posicionDestino;
    }

}
