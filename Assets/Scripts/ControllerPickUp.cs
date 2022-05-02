using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPickUp : PickUps
{
    [SerializeField] private Pickup pickup;
    [SerializeField] private GameObject poderUI;

    // Start is called before the first frame update
    void Start()
    {
        poderUI.GetComponentInChildren<TextMesh>().text = pickup.poder.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.GetComponent<ControlJugador>().AtacarPickUpBuff(pickup);
            Destroy(gameObject);

        }
    }
}
