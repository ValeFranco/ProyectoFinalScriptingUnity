using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJuego : MonoBehaviour
{
    public List<Torre> listaTorres = new List<Torre>();
    public TorreJugador torreJugador;

    public ControladorJuego()
    {

    }

    public string LimpiarLista()
    {
        bool pasoNivel = true;
        string mensaje = "No se ha ganado el nivel";
        foreach (TorreEnemigo item in listaTorres)
        {
            if (item == null)
            {
                listaTorres.Remove(item);
            }
        }
        if (listaTorres.Count == 0)
        {
            pasoNivel = true;
        }
        if (pasoNivel)
        {
            mensaje = "Pasaste de nivel";
        }
        return mensaje;
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
