using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float moveY;
    float bottomY = -3.85f;
    bool canMove = true;
    bool canTakeDamage = true;
    bool animHit = false;

    public string movementAxis = "Vertical";

    Vector2 posBeginning;

    Animator animator;

    Coroutine damageCoroutine;
    Coroutine damageCoroutine2;

    AudioSource _as;

    void Start()
    {
        animator = GetComponent<Animator>();
        _as = GetComponent<AudioSource>();
        canMove = true;
        canTakeDamage = true;
        animHit = false;
        posBeginning = transform.position;
    }

    void Update()
    {
        if (canMove && HUD.startedGame && HUD.endedGame == false)
        {
            moveY = Input.GetAxisRaw(movementAxis) * speed * Time.deltaTime;
            animator.SetFloat("MoveY", Input.GetAxisRaw(movementAxis));

            // If at the bottom of the screen, don't allow to move down.
            if (transform.position.y <= bottomY && moveY < 0)
            {
                moveY = 0;
            }

            // Change the player's position.
            transform.Translate(0f, moveY, 0f);
        }

        animator.SetBool("Hit", animHit);
        animator.SetBool("Finished", HUD.endedGame);
        animator.SetBool("CanMove", canMove);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Vehicle" && canTakeDamage == true && HUD.endedGame == false)
        {
            if (movementAxis == "Vertical")
            {
                if (damageCoroutine != null)
                {
                    StopCoroutine(damageCoroutine);
                }
                damageCoroutine = StartCoroutine(Hit());
            }
            else
            {
                if (damageCoroutine2 != null)
                {
                    StopCoroutine(damageCoroutine2);
                }
                damageCoroutine2 = StartCoroutine(Hit());
            }
        }

        if (collision.gameObject.tag == "Goal" && HUD.endedGame == false)
        {
            collision.gameObject.GetComponent<Finish>()._as.Play();

            if (collision.gameObject.GetComponent<Finish>().player1 == true)
            {
                HUD.score1++;
            }

            if (collision.gameObject.GetComponent<Finish>().player1 != true)
            {
                HUD.score2++;
            }

            transform.position = posBeginning;
            StartCoroutine(StopMovement(0.75f));
        }
    }

    private IEnumerator Hit()
    {
        canMove = false;
        animHit = true;

        _as.PlayOneShot(_as.clip);

        for (int i = 0; i < 50; i++)
        {
            // Move down if not already at the bottom.
            if (transform.position.y > bottomY)
            {
                transform.Translate(0f, -0.03f, 0f);
            }

            yield return new WaitForSeconds(0.01f);
        }

        canTakeDamage = true;

        yield return new WaitForSeconds(0.5f);

        canMove = true;
        animHit = false;
    }

    private IEnumerator StopMovement(float t)
    {
        canMove = false;

        yield return new WaitForSeconds(t);

        canMove = true;
    }
}
