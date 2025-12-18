using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public static bool startedGame;
    public static bool endedGame = false;
    public static int difficulty = 1;
    public Text points1_txt, points2_txt;
    public static int score1, score2;
    public GameObject spawner;
    GameObject[] vehiclesDestroy;

    AudioSource _as;

    void Start()
    {
        startedGame = false;
        endedGame = false;
        score1 = 0;
        score2 = 0;
        _as = GetComponent<AudioSource>();
        CreateDemo();
    }

    void Update()
    {
        if (startedGame == true)
        {
            points1_txt.text = score1.ToString();
            points2_txt.text = score2.ToString();

            if (Input.GetButtonDown("Jump")) // Reset game.
            {
                SceneManager.LoadScene("GameScene");
            }
        }
        else
        {
            points1_txt.text = difficulty.ToString();
            points2_txt.text = "";

            if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("Jump") || Input.GetButtonDown("Submit")) // Begin.
            {
                startedGame = true;
                spawner.GetComponent<Spawner>().StartedGame();

                StartCoroutine(FinishGame(136f));
                StartCoroutine(FinishGameFlash(128f));

                DestroyVehicles();
            }
            if (Input.GetButtonDown("Horizontal"))
            {
                _as.PlayOneShot(_as.clip);

                if (Input.GetAxisRaw("Horizontal") > 0.0f)
                {
                    difficulty++;
                }
                else if (Input.GetAxisRaw("Horizontal") < 0.0f)
                {
                    difficulty--;
                }

                CreateDemo();
            }
        }

        if (difficulty > 9)
        {
            difficulty = 1;
            CreateDemo();
        }
        if (difficulty < 1)
        {
            difficulty = 9;
            CreateDemo();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void DestroyVehicles()
    {
        vehiclesDestroy = GameObject.FindGameObjectsWithTag("Vehicle");
        foreach (GameObject v in vehiclesDestroy)
        {
            Destroy(v);
        }
    }

    private IEnumerator FinishGame(float t)
    {
        yield return new WaitForSeconds(t);
        endedGame = true;
    }

    private IEnumerator FinishGameFlash(float t)
    {
        yield return new WaitForSeconds(t);

        for (int i = 0; i < 32; i++)
        {
            points1_txt.enabled = !points1_txt.enabled;
            points2_txt.enabled = !points2_txt.enabled;
            yield return new WaitForSeconds(0.25f);
        }

        points1_txt.enabled = true;
        points2_txt.enabled = true;
    }

    void CreateDemo()
    {
        DestroyVehicles();

        switch (difficulty)
        {
            case 1:
                for (int i = 0; i < 10; i++)
                {
                    spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                }
                break;

            case 2:
                for (int i = 0; i < 10; i++)
                {
                    spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 3, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 6.5f);
                break;

            case 3:
                for (int i = 0; i < 10; i++)
                {
                    spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 3, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 5, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 4.2f);
                break;

            case 4:
                for (int i = 0; i < 10; i++)
                {
                    if (i != 4)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                    }
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 4.2f);
                break;

            case 5:
                for (int i = 0; i < 10; i++)
                {
                    if (i != 4)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                    }
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 7, -8.8f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 0, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 0, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 1.9f);
                break;

            case 6:
                for (int i = 0; i < 10; i++)
                {
                    spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                }

                for (int x = 0; x < 10; x++)
                {
                    spawner.GetComponent<Spawner>().CreateDemoVehicle(0, x, -8.8f);
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 3, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 6, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 9, 6.5f);
                break;

            case 7:
                for (int i = 0; i < 10; i++)
                {
                    if (i != 4 && i != 7)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                    }
                }

                for (int x = 0; x < 10; x++)
                {
                    if (x != 4 && x != 7)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(0, x, -8.8f);
                    }
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 0, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 0, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 3, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 6, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 7, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 1.9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 9, 6.5f);
                break;

            case 8:
                for (int i = 0; i < 10; i++)
                {
                    if (i != 4 && i != 7)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(0, i, 8.8f);
                    }
                }

                for (int x = 0; x < 10; x++)
                {
                    if (x != 4 && x != 7)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(0, x, -8.8f);
                    }
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 0, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 0, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 2, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 3, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 6, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 7, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 7, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, 1.9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 8, -0.4f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(0, 9, 6.5f);
                break;

            case 9:
                for (int i = 0; i < 10; i++)
                {
                    if (i != 4 && i != 7)
                    {
                        spawner.GetComponent<Spawner>().CreateDemoVehicle(1, i, 8.8f);
                    }
                }

                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 0, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 0, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 2, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 3, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 4, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 6, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 7, 9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 7, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 8, 6.5f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 8, 4.2f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 8, 1.9f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 8, -0.4f);
                spawner.GetComponent<Spawner>().CreateDemoVehicle(1, 9, 6.5f);
                break;

            default:
                break;
        }
    }
}
