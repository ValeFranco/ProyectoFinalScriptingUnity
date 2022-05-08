using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnemigo : MonoBehaviour
{
    [SerializeField] public Enemigo enemigo;
    [SerializeField] private GameObject poderUI;

    private void ActualizarVida()
    {
        poderUI.GetComponentInChildren<TextMesh>().text = enemigo.poder.ToString();
    }
    void Start()
    {
        
    }
    void Update()
    {
        ActualizarVida();
    }
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            //collider.GetComponent<ControlJugador>().AtacarEnemigo(enemigo);
            if (collider.GetComponent<ControlJugador>().AtacarEnemigo(enemigo))
            {
                Destroy(gameObject);
            }
        }
    }
}
