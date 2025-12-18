using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public bool left;
    public float speed;
    SpriteRenderer sr;
    public GameObject spawner;
    public bool changeColor;
    public int myLane;

    AudioSource _as;

    void Start()
    {
        _as = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();

        if (changeColor)
        {
            sr.color = Random.ColorHSV(0.0f, 1f, 0.25f, 1f, 0.75f, 1f);
        }

        if (left == true)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }

    void Update()
    {
        if (HUD.startedGame && HUD.endedGame == false)
        {
            if (left == false)
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);

                if (transform.position.x < spawner.GetComponent<Spawner>().rightX)
                {
                    transform.position = new Vector2(spawner.GetComponent<Spawner>().leftX, transform.position.y);
                    PlayEngineSound();
                }
            }
            else
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);

                if (transform.position.x > spawner.GetComponent<Spawner>().leftX)
                {
                    transform.position = new Vector2(spawner.GetComponent<Spawner>().rightX, transform.position.y);
                    PlayEngineSound();
                }
            }
        }
    }

    void PlayEngineSound()
    {
        if (Random.Range(0, 2) >= 1 && HUD.endedGame == false)
        {
            _as.PlayDelayed(Random.Range(0f, 10f));
        }
    }
}
