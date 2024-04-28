using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNoteSpawnManager : MonoBehaviour
{
    public GameObject[] enemiesToSpawn;
    public GameObject[] enemySpawnPointsX;

    private float enemyTimer = 0f;
    public float enemySpawnDelay = 2f;

    public GameObject SpawnedEnemy { get; set; }

    public string nomeNotaNemica;

    public SpawnManager smng;


    void Start()
    {

    }

    void Update()
    {
        enemyTimer += Time.deltaTime;

        if (enemyTimer >= enemySpawnDelay)
        {

            SpawnEnemy();
            enemyTimer = 0f;

        }

    }


    public GameObject SpawnEnemy()
    //void SpawnEnemy()
    {
        //prendo un prefab random dall array di prefab
        GameObject enemyToSpawn = enemiesToSpawn[Random.Range(0, enemiesToSpawn.Length)];

        //gli do una posizioneX random dall array 
        GameObject spawnPointX = enemySpawnPointsX[Random.Range(0, 3)];
        //Debug.Log("posizione di spawn x è " + spawnPointX);

        //mantengo invece per Y la posizione del prefab
        Vector3 spawnEnemyPosition = new(spawnPointX.transform.position.x, enemyToSpawn.transform.position.y, transform.position.z);

        //Vector3 spawnPosition = new(transform.position.x, enemyToSpawn.transform.position.y, transform.position.z);

        SpawnedEnemy = Instantiate(enemyToSpawn, spawnEnemyPosition, Quaternion.identity);
        SpawnedEnemy.name = enemyToSpawn.name;
        nomeNotaNemica = SpawnedEnemy.name;

        //GameObject spawnedEnemy = Instantiate(enemyToSpawn, spawnEnemyPosition, Quaternion.identity);
         Debug.Log("nota nemica spawnata " + nomeNotaNemica);
        CompareNames();

        Destroy(SpawnedEnemy, 15f);
        //CompareNames();

        return SpawnedEnemy;

        // Debug.Log("nota nemica autodistrutta");

        // Instantiate(notesToSpawn[Random.Range(0, notesToSpawn.Length)], transform.position, Quaternion.identity);

    }

    public void CompareNames()
    {
        //if (SpawnedEnemy.name != smng.spawnedNoteName)
        if (nomeNotaNemica != smng.spawnedNoteName)
        {
            Debug.Log("NOMI DIVERSI" + nomeNotaNemica + smng.spawnedNoteName);

        }

        else
        {
            Destroy(SpawnedEnemy);
            Debug.Log("i nomi sono uguali :( quindi intanto l'ho distrutta");
        }
    }

}