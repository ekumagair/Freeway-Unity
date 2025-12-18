using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public bool player1;
    public AudioSource _as;

    void Start()
    {
        _as = GetComponent<AudioSource>();
    }
}
