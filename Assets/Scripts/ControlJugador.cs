using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] private Jugador jugador;
    //[SerializeField] private Text poderUI;

    private float velocidad = 5f;
    private Vector2 posicionClick;
    private bool movimiento;
    // Start is called before the first frame update
    void Start()
    {
        //poderUI.text = jugador.poder.ToString();
        posicionClick = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posicionClick = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            movimiento = true;
        }

        if (movimiento && (Vector2)transform.position != posicionClick)
        {
            float step = velocidad * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, posicionClick, step);

        }
        else
        {
            movimiento = false;
        }

    }
}
