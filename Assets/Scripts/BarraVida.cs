using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Sprite[] corazones;
    // Start is called before the first frame update
    void Start()
    {
        CambioBarraVida(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambioBarraVida(int pos)
    {
        this.GetComponent<Image>().sprite = corazones[pos];
    }
}
