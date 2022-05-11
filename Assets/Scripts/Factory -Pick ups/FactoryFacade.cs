using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickUpType
{
    Buff,
    Debuff
}
public class FactoryFacade : MonoBehaviour
{
    [SerializeField] private BuffFactory buffFactory;
    [SerializeField] private DeBuffFactory deBuffFactory;

    public GameObject CrearNuevoPickUp(PickUpType pickUpType)
    {
        GameObject resultado = null;

        switch (pickUpType)
        {
            case PickUpType.Buff:
                resultado = buffFactory?.CrearNuevoPickUp();
                break;

            case PickUpType.Debuff:
                resultado = deBuffFactory?.CrearNuevoPickUp();
                break;
        }
        return resultado;
    }
}
