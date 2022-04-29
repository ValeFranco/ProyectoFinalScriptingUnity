using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] private Jugador jugador;

    private float velocidad = 5f;
    private Vector3 posicionDestino;
    // Start is called before the first frame update
    void Start()
    {
        posicionDestino = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicionDestino = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionDestino.z = this.transform.position.z;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position, posicionDestino, velocidad*Time.deltaTime);
    }
}
