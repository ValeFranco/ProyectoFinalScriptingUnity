using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crear Jugador", menuName = "Jugador")]
public class Jugador : ScriptableObject
{
    public uint poder;
    public string nombre;
    public byte vidas;

    [SerializeField] private Atacable atacable;
    [SerializeField] private TorreEnemigo torreEnenigo;
    public Jugador(uint poder, string nombre)
    {
        Poder = poder;
        Nombre = nombre;
        vidas = 3;
    }
    public uint Poder
    {
        get => poder;
        set
        {
            if (value > 0)
            {
                poder = value;
            }
            
               // throw new Exception("el poder inicial del usuario no puede ser cero");
        }
    }
    public string Nombre
    {
        get => nombre; set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                //throw new Exception("el nombre no puede tener espacios en blanco  ");
            }
            else
            {
                nombre = value;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //programar funcion atacar 
    internal bool Atacar(Atacable target, TorreEnemigo torreEnemigo)
    {
        bool victoria = false;

        if (torreEnemigo.listaAtacable.IndexOf(target) == -1)
        {
            //throw new Exception("el enemigo no está en esta torre");
        }
        if (target.esObstaculo == true)
        {
            poder += target.poder;
            victoria = true;
            return victoria;
        }
        if (target.esObstaculo == false)
        {
            if (target.poder > poder)
            {
                victoria = false;
                vidas--;
                return victoria;
            }
            if (target.poder == poder)
            {
                victoria = false;
                vidas--;
                return victoria;
            }
            else if (target.poder < poder)
            {
                victoria = true;
                poder += target.poder;
                //torreEnemigo.ReducirAltura(target);
                //AumentarAltura();

                //if (torreEnemigo.altura == 0 || torreEnemigo.listaAtacable.Count == 0)
                //{
                //    torreEnemigo = null;
                //}
                return victoria;
            }
        }
        return victoria;
    }
    //movimiento
    //morision
}
