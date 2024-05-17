using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMiniCookie : MonoBehaviour
{
    public GameObject[] spiralSpawnPoints;
    public GameObject spiralToSpawn;
    public bool cookieIsEaten = false;

    private float spiralTimer = 0f;
    public float spiralSpawnDelay = 0f;

    public ScoreLevel1 sl;

   


    void Start()
    {

    }

    void Update()
    {
        spiralTimer += Time.deltaTime;

        if (spiralTimer >= spiralSpawnDelay && sl.currentScoreValueLvl > 20)
        {

            SpawnSpiral();
            spiralTimer = 0f;

        }

    }


    public void SpawnSpiral()
    {

        //gli do una posizioneY random dall array 
        GameObject spawnPointY = spiralSpawnPoints[Random.Range(0, 5)];

        Vector3 spiralSpawnPosition = new(transform.position.x, spawnPointY.transform.position.y, transform.position.z);

        Instantiate(spiralToSpawn, spiralSpawnPosition, Quaternion.identity);
        
        Destroy(this.gameObject, 15f);
        

    }

    public void IsCookieHit()
    {
        cookieIsEaten = !cookieIsEaten;
    }
}
