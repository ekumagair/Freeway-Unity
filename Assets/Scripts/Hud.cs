using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hud : MonoBehaviour
{
    public static bool iniciouJogo;
    public static bool encerrouJogo = false;
    public static int dificuldade = 1;
    public Text pontos1_txt, pontos2_txt;
    public static int pontos1, pontos2;
    public GameObject spawner;
    GameObject[] vehiclesDestroy;

    AudioSource _as;

    void Start()
    {
        iniciouJogo = false;
        encerrouJogo = false;
        pontos1 = 0;
        pontos2 = 0;
        _as = GetComponent<AudioSource>();
        CriarDemo();
    }

    void Update()
    {
        if(iniciouJogo == true)
        {
            pontos1_txt.text = pontos1.ToString();
            pontos2_txt.text = pontos2.ToString();

            if(Input.GetButtonDown("Jump"))
            {
                SceneManager.LoadScene("GameScene");
            }
        }
        else
        {
            pontos1_txt.text = dificuldade.ToString();
            pontos2_txt.text = "";

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Jump") || Input.GetButtonDown("Submit")) // INICIAR
            {
                iniciouJogo = true;
                spawner.GetComponent<Spawner>().IniciouJogo();

                StartCoroutine(TerminarJogo(136f));
                StartCoroutine(TerminarJogoPiscar(128f));

                DestruirVeiculos();
            }
            if(Input.GetButtonDown("Horizontal"))
            {
                _as.PlayOneShot(_as.clip);

                if (Input.GetAxisRaw("Horizontal") > 0.0f)
                {
                    dificuldade++;
                }
                else if (Input.GetAxisRaw("Horizontal") < 0.0f)
                {
                    dificuldade--;
                }

                CriarDemo();
            }
        }

        if(dificuldade > 9)
        {
            dificuldade = 1;
            CriarDemo();
        }
        if(dificuldade < 1)
        {
            dificuldade = 9;
            CriarDemo();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void DestruirVeiculos()
    {
        vehiclesDestroy = GameObject.FindGameObjectsWithTag("Vehicle");
        foreach (GameObject v in vehiclesDestroy)
        {
            Destroy(v);
        }
    }

    IEnumerator TerminarJogo(float t)
    {
        yield return new WaitForSeconds(t);
        encerrouJogo = true;
    }

    IEnumerator TerminarJogoPiscar(float t)
    {
        yield return new WaitForSeconds(t);

        for (int i = 0; i < 32; i++)
        {
            pontos1_txt.enabled = !pontos1_txt.enabled;
            pontos2_txt.enabled = !pontos2_txt.enabled;
            yield return new WaitForSeconds(0.25f);
        }

        pontos1_txt.enabled = true;
        pontos2_txt.enabled = true;
    }

    void CriarDemo()
    {
        DestruirVeiculos();
        if (dificuldade == 1)
        {
            for (int i = 0; i < 10; i++)
            {
                spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
            }
        }
        if (dificuldade == 2)
        {
            for (int i = 0; i < 10; i++)
            {
                spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 3, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 6.5f);
        }
        if (dificuldade == 3)
        {
            for (int i = 0; i < 10; i++)
            {
                spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 3, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 5, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 4.2f);
        }
        if (dificuldade == 4)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i != 4)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
                }
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 4.2f);
        }
        if (dificuldade == 5)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i != 4)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
                }
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 7, -8.8f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 0, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 0, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 1.9f);
        }
        if (dificuldade == 6)
        {
            for (int i = 0; i < 10; i++)
            {
                spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
            }

            for (int x = 0; x < 10; x++)
            {
                spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, x, -8.8f);
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 3, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 6, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 9, 6.5f);
        }
        if (dificuldade == 7)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i != 4 && i != 7)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
                }
            }

            for (int x = 0; x < 10; x++)
            {
                if (x != 4 && x != 7)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, x, -8.8f);
                }
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 0, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 0, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 3, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 6, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 7, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 1.9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 9, 6.5f);
        }
        if (dificuldade == 8)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i != 4 && i != 7)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, i, 8.8f);
                }
            }

            for (int x = 0; x < 10; x++)
            {
                if (x != 4 && x != 7)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, x, -8.8f);
                }
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 0, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 0, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 2, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 3, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 6, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 7, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 7, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, 1.9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 8, -0.4f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(0, 9, 6.5f);
        }
        if (dificuldade == 9)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i != 4 && i != 7)
                {
                    spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, i, 8.8f);
                }
            }

            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 0, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 0, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 2, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 3, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 4, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 6, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 7, 9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 7, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 8, 6.5f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 8, 4.2f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 8, 1.9f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 8, -0.4f);
            spawner.GetComponent<Spawner>().CriarVeiculoDemo(1, 9, 6.5f);
        }
    }
}
