using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Veiculo : MonoBehaviour
{
    public bool esq;
    public float velocidade;
    SpriteRenderer sr;
    public GameObject spawner;
    public bool mudarCor;
    public int minhaFaixa;

    AudioSource _as;

    void Start()
    {
        _as = GetComponent<AudioSource>();
        sr = GetComponent<SpriteRenderer>();

        if(mudarCor)
        {
            sr.color = Random.ColorHSV(0.0f, 1f, 0.25f, 1f, 0.75f, 1f);
        }

        if(esq == true)
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
        if (Hud.iniciouJogo && Hud.encerrouJogo == false)
        {
            if (esq == false)
            {
                transform.Translate(-velocidade * Time.deltaTime, 0, 0);

                if (transform.position.x < spawner.GetComponent<Spawner>().dirX)
                {
                    transform.position = new Vector2(spawner.GetComponent<Spawner>().esqX, transform.position.y);
                    TocarSomDeMotor();
                }
            }
            else
            {
                transform.Translate(velocidade * Time.deltaTime, 0, 0);

                if (transform.position.x > spawner.GetComponent<Spawner>().esqX)
                {
                    transform.position = new Vector2(spawner.GetComponent<Spawner>().dirX, transform.position.y);
                    TocarSomDeMotor();
                }
            }
        }
    }

    void TocarSomDeMotor()
    {
        if(Random.Range(0, 2) >= 1 && Hud.encerrouJogo == false)
        {
            _as.PlayDelayed(Random.Range(0f, 10f));
        }
    }
}
