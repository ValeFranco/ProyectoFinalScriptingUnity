using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] private Jugador jugador;
    [SerializeField] private GameObject poderUI;

    public Image barravida;
    public float vida;
    public float vidaMaxima;
    private float velocidad = 5f;
    private Vector2 posicionClick;
    private bool movimiento;

    private void ActualizarVida()
    {
       poderUI.GetComponentInChildren<TextMesh>().text = jugador.poder.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        

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

        ActualizarVida();
       
        barravida.fillAmount = vida / vidaMaxima;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemigo"))
        {
            Debug.Log("se encontro con le enemigo");
            
        }

    }
}
