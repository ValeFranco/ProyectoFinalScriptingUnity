using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUps : MonoBehaviour
{
    [SerializeField] private uint poder;

    public uint Poder => poder;

}
