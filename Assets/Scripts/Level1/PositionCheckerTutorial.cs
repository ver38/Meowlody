using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckerTutorial : MonoBehaviour
{
    public SpawnManagerTutorial spManTut;

    public GameObject PositionChecker;

    private void Awake()
    {
        spManTut.NoteNameChanges();

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
            spManTut.NoteNameChanges();
            
        }


        else if
             (other.gameObject.CompareTag("WrongNote"))
        {
            spManTut.NoteNameChanges();
            Debug.Log("mostro nome su collisione");
        }
    }
}