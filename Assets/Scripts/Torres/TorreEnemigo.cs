using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorreEnemigo : MonoBehaviour
{

    public List<Pisos> listaPisos;

    public List<Pisos> ListaPisos { get => listaPisos; set => listaPisos = value; }

    public float deltaPosicion;

    public void RemoverPiso(int altura)
    {
        Destroy(ListaPisos[altura].gameObject);

        for (int i = altura + 1; i < listaPisos.Count; i++)
        {

            print("wenas");

            Vector3 posicionDestino = listaPisos[i].gameObject.transform.position;

            listaPisos[i].gameObject.transform.position = posicionDestino + (Vector3.down * deltaPosicion);


        }

        ListaPisos.RemoveAt(altura);

        print("ola");

    }

   
}
