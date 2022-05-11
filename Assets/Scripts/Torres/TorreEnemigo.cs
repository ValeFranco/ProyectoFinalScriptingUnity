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
        //Destroy(ListaPisos[altura].gameObject);

        StartCoroutine(DetenerCaida(altura));

       

       

        print("ola");

    }

    IEnumerator DetenerCaida(int altura)
    {
        Destroy(ListaPisos[altura].gameObject);

        yield return new WaitForSeconds(2f);

        for (int i = altura + 1; i < listaPisos.Count; i++)
        {

            Vector3 posicionDestino = listaPisos[i].gameObject.transform.position;

            listaPisos[i].gameObject.transform.position = posicionDestino + (Vector3.down * deltaPosicion);

        }

        ListaPisos.RemoveAt(altura);


        if (MyGameManager.Instance.torreEnemigo.listaPisos.Count == 0) //esta es la condici?n donde evaluamos que la lista este vacia
        {

            Destroy(MyGameManager.Instance.torreEnemigo);
            MyGameManager.Instance.Ganaste();


        }


    }


}
