using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floatText : MonoBehaviour
{
    [SerializeField] private Jugador Jugador;
    
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<TextMesh> = Jugador.poder.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
