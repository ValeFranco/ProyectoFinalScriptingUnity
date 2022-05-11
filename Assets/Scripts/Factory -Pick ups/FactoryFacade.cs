using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickUpType
{
    buff,
    deBuff
}
public class FactoryFacade : MonoBehaviour
{
    [SerializeField] private PickUpFactory buffFactory;
    [SerializeField] private DeBuffFactory debuffFactory; 

    public GameObject GetNewPickUp(PickUpType pickUpType)
    {
        GameObject result = null;
        switch (pickUpType)
        {
            case PickUpType.buff:
                result = buffFactory?.GetNewPickUP();
                break;
            case PickUpType.deBuff:
                result = debuffFactory?.GetNewPickUP();
                break;
        }
        return result;
    }
}
