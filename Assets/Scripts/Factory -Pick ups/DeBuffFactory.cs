using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuffFactory : MonoBehaviour
{
    [SerializeField] private GameObject debuffPickUp;
    // Start is called before the first frame update
    public GameObject GetNewPickUP()
    {
        GameObject Instance = Instantiate(debuffPickUp);
        return Instance;

    }

}
