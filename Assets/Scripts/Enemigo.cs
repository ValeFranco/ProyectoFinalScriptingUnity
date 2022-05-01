using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crear Enemigo", menuName = "Enemigo")]
public class Enemigo : ScriptableObject
{
    public TorreEnemigo torreEnemigo;
    public uint poder;

    public TorreEnemigo TorreEnemigo { get => torreEnemigo;  private set => torreEnemigo = value; }
    public uint Poder { get => poder; private set => poder = value; }

    public Enemigo(uint poder, TorreEnemigo torreEnemigo) 
    {
        this.TorreEnemigo = torreEnemigo;
        this.Poder = poder;

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
