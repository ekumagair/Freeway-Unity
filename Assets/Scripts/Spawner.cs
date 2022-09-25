using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] veiculos;
    public float[] faixas;
    public float esqX;
    public float dirX;

    public void IniciouJogo()
    {
        if (Hud.dificuldade == 1)
        {
            StartCoroutine(CriarVeiculo(0, 0, 1, 0));
            StartCoroutine(CriarVeiculo(0, 1, 2, 0));
            StartCoroutine(CriarVeiculo(0, 2, 4, 0));
            StartCoroutine(CriarVeiculo(0, 3, 1, 0));
            StartCoroutine(CriarVeiculo(0, 4, 4, 0));
            StartCoroutine(CriarVeiculo(0, 5, 3, 0));
            StartCoroutine(CriarVeiculo(0, 6, 2, 0));
            StartCoroutine(CriarVeiculo(0, 7, 4, 0));
            StartCoroutine(CriarVeiculo(0, 8, 3, 0));
            StartCoroutine(CriarVeiculo(0, 9, 5, 0));
        }
        if (Hud.dificuldade == 2)
        {
            StartCoroutine(CriarVeiculo(0, 0, 4, 0));
            StartCoroutine(CriarVeiculo(0, 1, 3, 0));
            StartCoroutine(CriarVeiculo(0, 2, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 3, 2, 0));
            StartCoroutine(CriarVeiculo(0, 3, 2, 1.1f));
            StartCoroutine(CriarVeiculo(0, 4, 5, 0));
            StartCoroutine(CriarVeiculo(0, 5, 4, 0));
            StartCoroutine(CriarVeiculo(0, 6, 3, 0));
            StartCoroutine(CriarVeiculo(0, 7, 5, 0));
            StartCoroutine(CriarVeiculo(0, 8, 4, 0));
            StartCoroutine(CriarVeiculo(0, 8, 4, 0.6f));
            StartCoroutine(CriarVeiculo(0, 9, 6.5f, 0));
        }
        if (Hud.dificuldade == 3)
        {
            StartCoroutine(CriarVeiculo(0, 0, 5, 0));
            StartCoroutine(CriarVeiculo(0, 1, 5, 0));
            StartCoroutine(CriarVeiculo(0, 2, 6, 0));
            StartCoroutine(CriarVeiculo(0, 3, 2, 0));
            StartCoroutine(CriarVeiculo(0, 3, 2, 1.1f));
            StartCoroutine(CriarVeiculo(0, 3, 2, 2.2f));
            StartCoroutine(CriarVeiculo(0, 4, 6, 0));
            StartCoroutine(CriarVeiculo(0, 5, 5, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0.6f));
            StartCoroutine(CriarVeiculo(0, 7, 8, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1f));
            StartCoroutine(CriarVeiculo(0, 9, 7, 0));
        }
        if (Hud.dificuldade == 4)
        {
            StartCoroutine(CriarVeiculo(0, 0, 6, 0));
            StartCoroutine(CriarVeiculo(0, 1, 5, 0));
            StartCoroutine(CriarVeiculo(0, 2, 6, 0));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0));
            StartCoroutine(CriarVeiculo(1, 4, 2, 0));
            StartCoroutine(CriarVeiculo(0, 5, 5, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0.6f));
            StartCoroutine(CriarVeiculo(0, 7, 8, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1f));
            StartCoroutine(CriarVeiculo(0, 9, 7, 0));
        }
        if (Hud.dificuldade == 5)
        {
            StartCoroutine(CriarVeiculo(0, 0, 6, 0));
            StartCoroutine(CriarVeiculo(0, 0, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 0, 6, 1.0f));
            StartCoroutine(CriarVeiculo(0, 1, 7, 0));
            StartCoroutine(CriarVeiculo(0, 2, 5, 0));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0));
            StartCoroutine(CriarVeiculo(1, 4, 2.5f, 0));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0.6f));
            StartCoroutine(CriarVeiculo(0, 7, 8.5f, 0));
            StartCoroutine(CriarVeiculo(0, 7, 8.5f, 4));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1.5f));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0));
        }
        if (Hud.dificuldade == 6)
        {
            StartCoroutine(CriarVeiculo(0, 0, 6, 0));
            StartCoroutine(CriarVeiculo(0, 0, 6, 3));
            StartCoroutine(CriarVeiculo(0, 1, 7, 0));
            StartCoroutine(CriarVeiculo(0, 1, 7, 3));
            StartCoroutine(CriarVeiculo(0, 2, 5, 0));
            StartCoroutine(CriarVeiculo(0, 2, 5, 3));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0.5f));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 3));
            StartCoroutine(CriarVeiculo(0, 4, 8, 0));
            StartCoroutine(CriarVeiculo(0, 4, 8, 3));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 0));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 3));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0.6f));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 3));
            StartCoroutine(CriarVeiculo(0, 7, 8.5f, 0));
            StartCoroutine(CriarVeiculo(0, 7, 8.5f, 3));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 3));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0.4f));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 5));
        }
        if (Hud.dificuldade == 7)
        {
            StartCoroutine(CriarVeiculo(0, 0, 6, 0));
            StartCoroutine(CriarVeiculo(0, 0, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 0, 6, 1.0f));
            StartCoroutine(CriarVeiculo(0, 0, 6, 3));
            StartCoroutine(CriarVeiculo(0, 1, 7, 0));
            StartCoroutine(CriarVeiculo(0, 1, 7, 3));
            StartCoroutine(CriarVeiculo(0, 2, 5, 0));
            StartCoroutine(CriarVeiculo(0, 2, 5, 3));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0.5f));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 3));
            StartCoroutine(CriarVeiculo(1, 4, 2.5f, 0));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 0));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 3));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0.6f));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 3));
            StartCoroutine(CriarVeiculo(1, 7, 1, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 3));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0.4f));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 5));
        }
        if (Hud.dificuldade == 8)
        {
            StartCoroutine(CriarVeiculo(0, 0, 6, 0));
            StartCoroutine(CriarVeiculo(0, 0, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 0, 6, 1.0f));
            StartCoroutine(CriarVeiculo(0, 0, 6, 3));
            StartCoroutine(CriarVeiculo(0, 1, 10, 0));
            StartCoroutine(CriarVeiculo(0, 1, 10, 3));
            StartCoroutine(CriarVeiculo(0, 2, 5, 0));
            StartCoroutine(CriarVeiculo(0, 2, 5, 0.6f));
            StartCoroutine(CriarVeiculo(0, 2, 5, 3));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 0.5f));
            StartCoroutine(CriarVeiculo(0, 3, 5.5f, 3));
            StartCoroutine(CriarVeiculo(1, 4, 3f, 0));
            StartCoroutine(CriarVeiculo(1, 4, 3f, 3));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 0));
            StartCoroutine(CriarVeiculo(0, 5, 4.5f, 3));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 0.6f));
            StartCoroutine(CriarVeiculo(0, 6, 5.5f, 3));
            StartCoroutine(CriarVeiculo(1, 7, 1.8f, 0));
            StartCoroutine(CriarVeiculo(1, 7, 1.8f, 3));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0));
            StartCoroutine(CriarVeiculo(0, 8, 6, 0.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 1.5f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 2f));
            StartCoroutine(CriarVeiculo(0, 8, 6, 3.5f));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 0.4f));
            StartCoroutine(CriarVeiculo(0, 9, 7.5f, 5));
        }
        if (Hud.dificuldade == 9)
        {
            StartCoroutine(CriarVeiculo(1, 0, 8, 0));
            StartCoroutine(CriarVeiculo(1, 0, 8, 0.5f));
            StartCoroutine(CriarVeiculo(1, 0, 8, 1.0f));
            StartCoroutine(CriarVeiculo(1, 1, 10, 0));
            StartCoroutine(CriarVeiculo(1, 2, 6, 0));
            StartCoroutine(CriarVeiculo(1, 2, 6, 0.6f));
            StartCoroutine(CriarVeiculo(1, 3, 7, 0));
            StartCoroutine(CriarVeiculo(1, 3, 7, 0.5f));
            StartCoroutine(CriarVeiculo(1, 4, 3f, 0));
            StartCoroutine(CriarVeiculo(1, 5, 5, 0));
            StartCoroutine(CriarVeiculo(1, 6, 6, 0));
            StartCoroutine(CriarVeiculo(1, 6, 6, 0.6f));
            StartCoroutine(CriarVeiculo(1, 7, 5, 0));
            StartCoroutine(CriarVeiculo(1, 8, 6, 0));
            StartCoroutine(CriarVeiculo(1, 8, 6, 0.5f));
            StartCoroutine(CriarVeiculo(1, 8, 6, 1f));
            StartCoroutine(CriarVeiculo(1, 8, 6, 1.5f));
            StartCoroutine(CriarVeiculo(1, 8, 6, 2f));
            StartCoroutine(CriarVeiculo(1, 9, 8, 0));
            StartCoroutine(CriarVeiculo(1, 9, 8, 0.4f));
        }

        StartCoroutine(MudarVelocidade(10f));
    }

    IEnumerator CriarVeiculo(int v, int f, float velocidade, float tempo)
    {
        yield return new WaitForSeconds(tempo);

        float posX;
        bool esq;

        if(f <= 4)
        {
            esq = true;
        }
        else
        {
            esq = false;
        }

        if (esq == true)
        {
            posX = esqX;
        }
        else
        {
            posX = dirX;
        }

        var spawned = Instantiate(veiculos[v], new Vector2(posX, faixas[f]), transform.rotation);
        spawned.GetComponent<Veiculo>().esq = esq;
        spawned.GetComponent<Veiculo>().minhaFaixa = f;
        spawned.GetComponent<Veiculo>().velocidade = velocidade;
        spawned.GetComponent<Veiculo>().spawner = gameObject;
    }

    public void CriarVeiculoDemo(int v, int f, float x)
    {
        bool esq;

        if (f <= 4)
        {
            esq = true;
        }
        else
        {
            esq = false;
        }

        var spawned = Instantiate(veiculos[v], new Vector2(x, faixas[f]), transform.rotation);
        spawned.GetComponent<Veiculo>().velocidade = 0f;
        spawned.GetComponent<Veiculo>().esq = esq;
    }

    IEnumerator MudarVelocidade(float t)
    {
        int qualF;
        GameObject[] v;
        float novaVel;

        yield return new WaitForSeconds(t);

        qualF = Random.Range(0, 10);
        novaVel = Random.Range(0.6f, 1.4f);
        v = GameObject.FindGameObjectsWithTag("Vehicle");

        Debug.Log("Mudou velocidade. (Faixa " + qualF + " ; x" + novaVel + ")");

        foreach (GameObject veiculo in v)
        {
            if(veiculo.GetComponent<Veiculo>().minhaFaixa == qualF && veiculo != null)
            {
                veiculo.GetComponent<Veiculo>().velocidade *= novaVel;
            }
        }

        StartCoroutine(MudarVelocidade(10f));
    }
}
