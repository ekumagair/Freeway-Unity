using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chegada : MonoBehaviour
{
    public bool jogador1;
    public AudioSource _as;

    private void Start()
    {
        _as = GetComponent<AudioSource>();
    }
}
