using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSemiminime : MonoBehaviour
{
    public GameObject semiminima;
    public float maxX;
    public float minX;
    public GameObject axisContainer; 
    public float timeBetweenSpawn;
    private float spawnTime;

    void Start()
    {
        spawnTime = Time.time + timeBetweenSpawn;
    }

    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        Transform[] spawnAxes = GetAxesFromContainer();

        if (spawnAxes.Length < 2)
        {
            Debug.LogWarning("could not find any axis in the container.");
            return;
        }

        Transform axis1 = spawnAxes[Random.Range(0, spawnAxes.Length)];
        Transform axis2 = axis1;
        while (axis2 == axis1)
        {
            axis2 = spawnAxes[Random.Range(0, spawnAxes.Length)];
        }

        Vector3 axis1Position = axis1.position;
        Vector3 axis2Position = axis2.position;

        float randomX1 = Random.Range(minX, maxX);
        float randomX2 = Random.Range(minX, maxX);

        Instantiate(semiminima, new Vector3(axis1Position.x + randomX1, axis1Position.y, axis1Position.z), Quaternion.identity);
        Instantiate(semiminima, new Vector3(axis2Position.x + randomX2, axis2Position.y, axis2Position.z), Quaternion.identity);
    }

    Transform[] GetAxesFromContainer()
    {
        if (axisContainer != null)
        {
            Transform[] axes = new Transform[axisContainer.transform.childCount];
            for (int i = 0; i < axisContainer.transform.childCount; i++)
            {
                axes[i] = axisContainer.transform.GetChild(i);
            }
            return axes;
        }
        else
        {
            Debug.LogError("could not find axis container");
            return new Transform[0];
        }
    }
}
