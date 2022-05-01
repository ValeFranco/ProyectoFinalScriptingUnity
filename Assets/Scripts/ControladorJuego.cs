using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJuego : MonoBehaviour
{
    public List<TorreEnemigo> listaTorresEnemigo = new List<TorreEnemigo>();
    public TorreJugador torreJugador;

    public ControladorJuego()
    {

    }

    public string LimpiarLista()
    {
        bool pasoNivel = true;
        string mensaje = "No se ha ganado el nivel";
        foreach (TorreEnemigo item in listaTorresEnemigo)
        {
            if (item == null)
            {
                listaTorresEnemigo.Remove(item);
            }
        }
        if (listaTorresEnemigo.Count == 0)
        {
            pasoNivel = true;
        }
        if (pasoNivel)
        {
            mensaje = "Pasaste de nivel";
        }
        return mensaje;
    }
}
