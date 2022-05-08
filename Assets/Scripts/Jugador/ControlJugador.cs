using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlJugador : MonoBehaviour
{
    [SerializeField] public Jugador jugador;
    [SerializeField] private GameObject poderUI;

    public Image barravida;
    private float velocidad = 5f;
    private Vector2 posicionClick;
    private bool movimiento;
    
    public GameObject gameOver;
    public bool isDead;

    private TorreJugador torreJugador;

    public BarraVida barraCanvas;

    public Jugador Jugador { get => jugador; set => jugador = value; }

    private void ActualizarVida()
    {
       poderUI.GetComponentInChildren<TextMesh>().text = Jugador.poder.ToString();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
        
        
        //condiciones iniciales Jugador:
        Jugador.vidas = 3;
        Jugador.poder = Jugador.basepoder; //se reinicia el poder del jugador al base
        
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
        if (enemigo.Poder > Jugador.poder)
        {
            victoria = false;

            Salud();

            return victoria;
        }
        if (enemigo.Poder == Jugador.poder)
        {
            victoria = false;
            Salud();
            return victoria;
        }
        else if (enemigo.Poder < Jugador.poder)
        {
            victoria = true;
            Jugador.poder += enemigo.Poder;
            foreach (var item in GameManager.Instance.torreEnemigo.listaPisos)
            {
                if(item.enemigo == enemigo)
                {
                    GameManager.Instance.torreEnemigo.RemoverPiso(item.altura);
                }
            }


            if (GameManager.Instance.torreEnemigo.listaPisos.Count == 0) //esta es la condici?n donde evaluamos que la lista este vacia
            {

                Destroy(GameManager.Instance.torreEnemigo);


            }
            return victoria;
        }

        return victoria;
    }
    public bool AtacarPickUpBuff(Pickup target)
    {
        bool victoria;
        Jugador.poder += target.Poder;
        victoria = true;

        return victoria;
    }
    public bool AtacarPickUpDebuff(Pickup target)
    {
        bool victoria;
        Jugador.poder -= target.Poder;
        victoria = true;

        return victoria;
    }
    public void Salud()
    {
        Jugador.vidas--; 

        barraCanvas.CambioBarraVida(Jugador.vidas);

        if (Jugador.Vidas <= 0)
        {
           isDead = true;
            gameOver.SetActive(true);
        }
    }
}
