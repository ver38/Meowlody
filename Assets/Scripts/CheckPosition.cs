using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPosition : MonoBehaviour
{
    public SpawnManager spawnman;

    public GameObject PositionChecker;

    private void Awake()
    {
        spawnman.NoteNameChanges();

    }


    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Nota"))

        {
            spawnman.NoteNameChanges();
            //Debug.Log("CARNAGE");

            //  Debug.Log("collisione con nota amica");
        }


        else if
             (other.gameObject.CompareTag("WrongNote"))
        {
            spawnman.NoteNameChanges();
             Debug.Log("mostro nome su collisione");
        }
    }
}