using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] private Jugador jugador;
    [SerializeField] private GameObject poderUI;

    public Image barravida;
    private float velocidad = 5f;
    private Vector2 posicionClick;
    private bool movimiento;
    
    public GameObject gameOver;
    public bool isDead;

    private TorreJugador torreJugador;

    public BarraVida barraCanvas;
    

    private void ActualizarVida()
    {
       poderUI.GetComponentInChildren<TextMesh>().text = jugador.poder.ToString();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        
        
        //condiciones iniciales Jugador:
        jugador.vidas = 3;
        jugador.poder = jugador.basepoder;
        
        barraCanvas = GameObject.FindObjectOfType<BarraVida>();
        posicionClick = this.transform.position;
    }
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
      

    }
    public bool AtacarEnemigo(Enemigo enemigo)
    {
        bool victoria = false;
        if (enemigo.Poder > jugador.poder)
        {
            victoria = false;

            Salud();

            return victoria;
        }
        if (enemigo.Poder == jugador.poder)
        {
            victoria = false;
            Salud();
            return victoria;
        }
        else if (enemigo.Poder < jugador.poder)
        {
            victoria = true;
            jugador.poder += enemigo.Poder;
            //enemigo.TorreEnemigo.ReducirAltura(enemigo);
            //torreJugador.AumentarAltura();
            

            if (enemigo.TorreEnemigo.altura == 0 || enemigo.TorreEnemigo.listaEnemigos.Count == 0)
            {
                enemigo.torreEnemigo = null;
            }
            return victoria;
        }

        return victoria;
    }
    public bool AtacarPickUp(Pickup target)
    {
        bool victoria;
        jugador.poder += target.Poder;
        victoria = true;

        return victoria;
    }
    public void Salud()
    {
        jugador.vidas--; 

        barraCanvas.CambioBarraVida(jugador.vidas);

        if (jugador.Vidas <= 0)
        {
           isDead = true;
            gameOver.SetActive(true);
        }
    }
}
