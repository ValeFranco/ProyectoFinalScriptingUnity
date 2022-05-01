using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    [SerializeField] private Enemigo enemigo;
    [SerializeField] private GameObject poderUI;

    private void ActualizarVida()
    {
        poderUI.GetComponentInChildren<TextMesh>().text = enemigo.poder.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
