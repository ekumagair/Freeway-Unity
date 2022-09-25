using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade;
    float mover_y;
    bool podeMover = true;
    bool podeLevarDano = true;
    bool animHit = false;

    public string movementAxis = "Vertical";

    Vector2 posInicio;

    Animator animator;

    Coroutine danoC;
    Coroutine danoC2;

    AudioSource _as;

    void Start()
    {
        animator = GetComponent<Animator>();
        _as = GetComponent<AudioSource>();
        podeMover = true;
        podeLevarDano = true;
        animHit = false;
        posInicio = transform.position;
    }

    void Update()
    {
        if(podeMover && Hud.iniciouJogo && Hud.encerrouJogo == false)
        {
            mover_y = Input.GetAxisRaw(movementAxis) * velocidade * Time.deltaTime;
            animator.SetFloat("MoveY", Input.GetAxisRaw(movementAxis));
            transform.Translate(0f, mover_y, 0f);
        }

        animator.SetBool("Hit", animHit);
        animator.SetBool("Encerrou", Hud.encerrouJogo);
        animator.SetBool("PodeMover", podeMover);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Vehicle" && podeLevarDano == true && Hud.encerrouJogo == false)
        {
            if(movementAxis == "Vertical")
            {
                if (danoC != null)
                {
                    StopCoroutine(danoC);
                }
                danoC = StartCoroutine(Atingido());
            }
            else
            {
                if (danoC2 != null)
                {
                    StopCoroutine(danoC2);
                }
                danoC2 = StartCoroutine(Atingido());
            }
        }

        if(collision.gameObject.tag == "Goal" && Hud.encerrouJogo == false)
        {
            collision.gameObject.GetComponent<Chegada>()._as.Play();
            if(collision.gameObject.GetComponent<Chegada>().jogador1 == true)
            {
                Hud.pontos1++;
            }
            else if (Hud.pontos1 > 0)
            {
                //Hud.pontos1--;
            }

            if (collision.gameObject.GetComponent<Chegada>().jogador1 != true)
            {
                Hud.pontos2++;
            }
            else if (Hud.pontos2 > 0)
            {
                //Hud.pontos2--;
            }

            transform.position = posInicio;
            StartCoroutine(PararMovimento(0.75f));
        }
    }

    IEnumerator Atingido()
    {
        podeMover = false;
        animHit = true;
        //podeLevarDano = false;

        _as.PlayOneShot(_as.clip);

        for (int i = 0; i < 50; i++)
        {
            transform.Translate(0f, -0.03f, 0f);
            yield return new WaitForSeconds(0.01f);
        }

        podeLevarDano = true;

        yield return new WaitForSeconds(0.5f);

        podeMover = true;
        animHit = false;
    }

    IEnumerator PararMovimento(float t)
    {
        podeMover = false;
        yield return new WaitForSeconds(t);
        podeMover = true;
    }
}
