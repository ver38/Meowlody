using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] notesToSpawn;
    private float timer = 0f;
    public float spawnDelay = 1f;
    public ScoreManager scorMan;
    public Text textObject;

    public string spawnedNoteName;

    public GameObject SpawnedNote { get; private set; }




    void Start()
    {
        //nascondo il testo all inizio
        textObject.gameObject.SetActive(false);

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnDelay)
        {
            GameObject spawnedNote = SpawnNotes();

            //SpawnNotes();
            timer = 0f;
        }
    }

    public GameObject SpawnNotes()
    {

        GameObject noteToSpawn = notesToSpawn[Random.Range(0, notesToSpawn.Length)];

        Vector3 spawnPosition = new(transform.position.x, noteToSpawn.transform.position.y, transform.position.z);

        // GameObject spawnedNote = Instantiate(noteToSpawn, spawnPosition, Quaternion.identity);
        SpawnedNote = Instantiate(noteToSpawn, spawnPosition, Quaternion.identity);


        textObject.gameObject.SetActive(true);

        //gli do il nome origiale del prefab
        SpawnedNote.name = noteToSpawn.name;
        Debug.Log("nota amica spawnata" + SpawnedNote.name);

        spawnedNoteName = SpawnedNote.name;
        //string spawnedNoteName = SpawnedNote.name;

        StartCoroutine(UpdateTextWithDelay(spawnedNoteName, 3));
        // Debug.Log("into coroutine");

        textObject.text = spawnedNoteName;

        Destroy(SpawnedNote, 10f);
        //Debug.Log("nota amica autodistrutta");
        return SpawnedNote;

    }

    IEnumerator UpdateTextWithDelay(string showedText, float delay)
    {
        //yield return new WaitForSeconds(delay);
          yield return new WaitForSecondsRealtime(delay);
        textObject.text = showedText;
    }
}
