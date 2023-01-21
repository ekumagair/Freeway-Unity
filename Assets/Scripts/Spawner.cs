using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] vehicles;
    public float[] lanes;
    public float leftX;
    public float rightX;

    public void StartedGame()
    {
        switch (HUD.difficulty)
        {
            case 1:
                StartCoroutine(CreateVehicle(0, 0, 1, 0));
                StartCoroutine(CreateVehicle(0, 1, 2, 0));
                StartCoroutine(CreateVehicle(0, 2, 4, 0));
                StartCoroutine(CreateVehicle(0, 3, 1, 0));
                StartCoroutine(CreateVehicle(0, 4, 4, 0));
                StartCoroutine(CreateVehicle(0, 5, 3, 0));
                StartCoroutine(CreateVehicle(0, 6, 2, 0));
                StartCoroutine(CreateVehicle(0, 7, 4, 0));
                StartCoroutine(CreateVehicle(0, 8, 3, 0));
                StartCoroutine(CreateVehicle(0, 9, 5, 0));
                break;

            case 2:
                StartCoroutine(CreateVehicle(0, 0, 4, 0));
                StartCoroutine(CreateVehicle(0, 1, 3, 0));
                StartCoroutine(CreateVehicle(0, 2, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 3, 2, 0));
                StartCoroutine(CreateVehicle(0, 3, 2, 1.1f));
                StartCoroutine(CreateVehicle(0, 4, 5, 0));
                StartCoroutine(CreateVehicle(0, 5, 4, 0));
                StartCoroutine(CreateVehicle(0, 6, 3, 0));
                StartCoroutine(CreateVehicle(0, 7, 5, 0));
                StartCoroutine(CreateVehicle(0, 8, 4, 0));
                StartCoroutine(CreateVehicle(0, 8, 4, 0.6f));
                StartCoroutine(CreateVehicle(0, 9, 6.5f, 0));
                break;

            case 3:
                StartCoroutine(CreateVehicle(0, 0, 5, 0));
                StartCoroutine(CreateVehicle(0, 1, 5, 0));
                StartCoroutine(CreateVehicle(0, 2, 6, 0));
                StartCoroutine(CreateVehicle(0, 3, 2, 0));
                StartCoroutine(CreateVehicle(0, 3, 2, 1.1f));
                StartCoroutine(CreateVehicle(0, 3, 2, 2.2f));
                StartCoroutine(CreateVehicle(0, 4, 6, 0));
                StartCoroutine(CreateVehicle(0, 5, 5, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0.6f));
                StartCoroutine(CreateVehicle(0, 7, 8, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1f));
                StartCoroutine(CreateVehicle(0, 9, 7, 0));
                break;

            case 4:
                StartCoroutine(CreateVehicle(0, 0, 6, 0));
                StartCoroutine(CreateVehicle(0, 1, 5, 0));
                StartCoroutine(CreateVehicle(0, 2, 6, 0));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0));
                StartCoroutine(CreateVehicle(1, 4, 2, 0));
                StartCoroutine(CreateVehicle(0, 5, 5, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0.6f));
                StartCoroutine(CreateVehicle(0, 7, 8, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1f));
                StartCoroutine(CreateVehicle(0, 9, 7, 0));
                break;

            case 5:
                StartCoroutine(CreateVehicle(0, 0, 6, 0));
                StartCoroutine(CreateVehicle(0, 0, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 0, 6, 1.0f));
                StartCoroutine(CreateVehicle(0, 1, 7, 0));
                StartCoroutine(CreateVehicle(0, 2, 5, 0));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0));
                StartCoroutine(CreateVehicle(1, 4, 2.5f, 0));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0.6f));
                StartCoroutine(CreateVehicle(0, 7, 8.5f, 0));
                StartCoroutine(CreateVehicle(0, 7, 8.5f, 4));
                StartCoroutine(CreateVehicle(0, 8, 6, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1.5f));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0));
                break;

            case 6:
                StartCoroutine(CreateVehicle(0, 0, 6, 0));
                StartCoroutine(CreateVehicle(0, 0, 6, 3));
                StartCoroutine(CreateVehicle(0, 1, 7, 0));
                StartCoroutine(CreateVehicle(0, 1, 7, 3));
                StartCoroutine(CreateVehicle(0, 2, 5, 0));
                StartCoroutine(CreateVehicle(0, 2, 5, 3));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0.5f));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 3));
                StartCoroutine(CreateVehicle(0, 4, 8, 0));
                StartCoroutine(CreateVehicle(0, 4, 8, 3));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 0));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 3));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0.6f));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 3));
                StartCoroutine(CreateVehicle(0, 7, 8.5f, 0));
                StartCoroutine(CreateVehicle(0, 7, 8.5f, 3));
                StartCoroutine(CreateVehicle(0, 8, 6, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 3));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0.4f));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 5));
                break;

            case 7:
                StartCoroutine(CreateVehicle(0, 0, 6, 0));
                StartCoroutine(CreateVehicle(0, 0, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 0, 6, 1.0f));
                StartCoroutine(CreateVehicle(0, 0, 6, 3));
                StartCoroutine(CreateVehicle(0, 1, 7, 0));
                StartCoroutine(CreateVehicle(0, 1, 7, 3));
                StartCoroutine(CreateVehicle(0, 2, 5, 0));
                StartCoroutine(CreateVehicle(0, 2, 5, 3));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0.5f));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 3));
                StartCoroutine(CreateVehicle(1, 4, 2.5f, 0));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 0));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 3));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0.6f));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 3));
                StartCoroutine(CreateVehicle(1, 7, 1, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 3));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0.4f));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 5));
                break;

            case 8:
                StartCoroutine(CreateVehicle(0, 0, 6, 0));
                StartCoroutine(CreateVehicle(0, 0, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 0, 6, 1.0f));
                StartCoroutine(CreateVehicle(0, 0, 6, 3));
                StartCoroutine(CreateVehicle(0, 1, 10, 0));
                StartCoroutine(CreateVehicle(0, 1, 10, 3));
                StartCoroutine(CreateVehicle(0, 2, 5, 0));
                StartCoroutine(CreateVehicle(0, 2, 5, 0.6f));
                StartCoroutine(CreateVehicle(0, 2, 5, 3));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 0.5f));
                StartCoroutine(CreateVehicle(0, 3, 5.5f, 3));
                StartCoroutine(CreateVehicle(1, 4, 3f, 0));
                StartCoroutine(CreateVehicle(1, 4, 3f, 3));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 0));
                StartCoroutine(CreateVehicle(0, 5, 4.5f, 3));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 0.6f));
                StartCoroutine(CreateVehicle(0, 6, 5.5f, 3));
                StartCoroutine(CreateVehicle(1, 7, 1.8f, 0));
                StartCoroutine(CreateVehicle(1, 7, 1.8f, 3));
                StartCoroutine(CreateVehicle(0, 8, 6, 0));
                StartCoroutine(CreateVehicle(0, 8, 6, 0.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1f));
                StartCoroutine(CreateVehicle(0, 8, 6, 1.5f));
                StartCoroutine(CreateVehicle(0, 8, 6, 2f));
                StartCoroutine(CreateVehicle(0, 8, 6, 3.5f));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 0.4f));
                StartCoroutine(CreateVehicle(0, 9, 7.5f, 5));
                break;

            case 9:
                StartCoroutine(CreateVehicle(1, 0, 8, 0));
                StartCoroutine(CreateVehicle(1, 0, 8, 0.5f));
                StartCoroutine(CreateVehicle(1, 0, 8, 1.0f));
                StartCoroutine(CreateVehicle(1, 1, 10, 0));
                StartCoroutine(CreateVehicle(1, 2, 6, 0));
                StartCoroutine(CreateVehicle(1, 2, 6, 0.6f));
                StartCoroutine(CreateVehicle(1, 3, 7, 0));
                StartCoroutine(CreateVehicle(1, 3, 7, 0.5f));
                StartCoroutine(CreateVehicle(1, 4, 3f, 0));
                StartCoroutine(CreateVehicle(1, 5, 5, 0));
                StartCoroutine(CreateVehicle(1, 6, 6, 0));
                StartCoroutine(CreateVehicle(1, 6, 6, 0.6f));
                StartCoroutine(CreateVehicle(1, 7, 5, 0));
                StartCoroutine(CreateVehicle(1, 8, 6, 0));
                StartCoroutine(CreateVehicle(1, 8, 6, 0.5f));
                StartCoroutine(CreateVehicle(1, 8, 6, 1f));
                StartCoroutine(CreateVehicle(1, 8, 6, 1.5f));
                StartCoroutine(CreateVehicle(1, 8, 6, 2f));
                StartCoroutine(CreateVehicle(1, 9, 8, 0));
                StartCoroutine(CreateVehicle(1, 9, 8, 0.4f));
                break;

            default:
                break;
        }

        StartCoroutine(ChangeSpeed(10f));
    }

    IEnumerator CreateVehicle(int v, int f, float speed, float delay)
    {
        yield return new WaitForSeconds(delay);

        float posX;
        bool left;

        if(f <= 4)
        {
            left = true;
        }
        else
        {
            left = false;
        }

        if (left == true)
        {
            posX = leftX;
        }
        else
        {
            posX = rightX;
        }

        var spawned = Instantiate(vehicles[v], new Vector2(posX, lanes[f]), transform.rotation);
        spawned.GetComponent<Vehicle>().left = left;
        spawned.GetComponent<Vehicle>().myLane = f;
        spawned.GetComponent<Vehicle>().speed = speed;
        spawned.GetComponent<Vehicle>().spawner = gameObject;
    }

    public void CreateDemoVehicle(int v, int f, float x)
    {
        bool left;

        if (f <= 4)
        {
            left = true;
        }
        else
        {
            left = false;
        }

        var spawned = Instantiate(vehicles[v], new Vector2(x, lanes[f]), transform.rotation);
        spawned.GetComponent<Vehicle>().speed = 0f;
        spawned.GetComponent<Vehicle>().left = left;
    }

    IEnumerator ChangeSpeed(float t)
    {
        int whichLane;
        GameObject[] allVehicles;
        float newSpeed;

        yield return new WaitForSeconds(t);

        whichLane = Random.Range(0, 10);
        newSpeed = Random.Range(0.6f, 1.4f);
        allVehicles = GameObject.FindGameObjectsWithTag("Vehicle");

        Debug.Log("Changed speed. (Lane " + whichLane + " ; x" + newSpeed + ")");

        foreach (GameObject vehicle in allVehicles)
        {
            if(vehicle.GetComponent<Vehicle>().myLane == whichLane && vehicle != null)
            {
                vehicle.GetComponent<Vehicle>().speed *= newSpeed;
            }
        }

        StartCoroutine(ChangeSpeed(10f));
    }
}
