using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMinicookie : MonoBehaviour
{

    public GameObject minicookie;
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

        if (spawnAxes.Length == 0)
        {
            Debug.LogWarning("could not find any axis in the container");
            return;
        }

        Transform selectedAxis = spawnAxes[Random.Range(0, spawnAxes.Length)];
        Vector3 axisPosition = selectedAxis.position;

        float randomX = Random.Range(minX, maxX);

        Instantiate(minicookie, new Vector3(axisPosition.x + randomX, axisPosition.y, axisPosition.z), Quaternion.identity);
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
            Debug.LogError("could not find any axis container");
            return new Transform[0];
        }
    }
}
