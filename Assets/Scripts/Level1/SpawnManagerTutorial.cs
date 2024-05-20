using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpawnManagerTutorial : MonoBehaviour
{
    public GameObject[] notesToSpawn;
    private float timer = 0f;
    public float spawnNoteDelay = 0f;

    public ScoreLevel1 scorMan;
    public SpawnMiniCookie spawnmc;
   // public TutorialManager tutMan;

    public Text textObject;

    public string spawnedNotesName; 

    public GameObject SpawnedNotes { get; private set; }




    void Start()
    {
        //nascondo il testo all inizio
        textObject.gameObject.SetActive(false);

    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnNoteDelay)

            //if (timer >= spawnNoteDelay && tutMan.isTutorialFinished == true)
        {
           // SpawnLinesNotes();
            SpawnSystem();
            timer = 0f;
        }
    }



    public GameObject SpawnSpacesNotes()
    {
        {
            GameObject noteToSpawn = notesToSpawn[Random.Range(6, notesToSpawn.Length)];
            Vector3 spawnPosition = new(transform.position.x, noteToSpawn.transform.position.y, transform.position.z);

            SpawnedNotes = Instantiate(noteToSpawn, spawnPosition, Quaternion.identity);

            textObject.gameObject.SetActive(true);

            SpawnedNotes.name = noteToSpawn.name;
            spawnedNotesName = SpawnedNotes.name;
            textObject.text = spawnedNotesName;

            Destroy(SpawnedNotes, 10f);
            return SpawnedNotes;

        }
    }


    public GameObject SpawnLinesNotes()
    {
        {
            GameObject noteToSpawn = notesToSpawn[Random.Range(0, 6)];
            Vector3 spawnPosition = new(transform.position.x, noteToSpawn.transform.position.y, transform.position.z);

            SpawnedNotes = Instantiate(noteToSpawn, spawnPosition, Quaternion.identity);

            textObject.gameObject.SetActive(true);

            SpawnedNotes.name = noteToSpawn.name;
            spawnedNotesName = SpawnedNotes.name;
            textObject.text = spawnedNotesName;

            Destroy(SpawnedNotes, 10f);
            return SpawnedNotes;

        }
    }

    public void SpawnSystem()
    {

        if (spawnmc.cookieIsEaten == false)
        {
            SpawnLinesNotes();
    Debug.Log("spawno note sulle linee");
        }

        else if (spawnmc.cookieIsEaten == true )
            { 
            SpawnSpacesNotes();
    Debug.Log("spawno note negli spazi");
        }

    }


    public void NoteNameChanges()
    {
        textObject.gameObject.SetActive(true);
        // Debug.Log("sto dentro");

    }
}