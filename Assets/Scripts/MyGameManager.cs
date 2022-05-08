using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public static MyGameManager Instance;
    public TorreEnemigo torreEnemigo;
    public TorreJugador torreJugador;
    public ControlJugador jugador;
    public GameObject ganaste;
    

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
           
        }
    }


    void Start()
    {
        ganaste.SetActive(false);
    }

    void Update()
    {

    }

    public void Ganaste()
    {
        ganaste.SetActive(true);
    }
}
