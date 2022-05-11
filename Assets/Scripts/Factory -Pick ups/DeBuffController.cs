using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeBuffController : PickUps
{
    [SerializeField] private Pickup pickup;
    [SerializeField] private GameObject poderUI;


    void Start()
    {
        poderUI.GetComponentInChildren<TextMesh>().text = pickup.poder.ToString();
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.GetComponent<ControlJugador>().AtacarPickUpDebuff(pickup);
            Destroy(gameObject);

        }
    }
}
