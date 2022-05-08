using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
     private static MyGameManager instance;
    [SerializeField] internal TorreEnemigo torreEnemigo;
    [SerializeField] internal TorreJugador torreJugador;
    [SerializeField] private ControlJugador jugador;
    public GameObject ganaste;
    
    public static MyGameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = null;
        }
    }


    void Start()
    {
        ganaste.SetActive(false);
    }

    void Update()
    {

    }
}
