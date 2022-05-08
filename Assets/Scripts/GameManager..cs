using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
     public TorreEnemigo torreEnemigo;
    private TorreJugador torreJugador;
     private ControlJugador jugador;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if(instance != null)
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
        
    }

    void Update()
    {
        
    }
}
