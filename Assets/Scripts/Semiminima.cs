using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Semiminima : MonoBehaviour
//public class NewBehaviourScript : MonoBehaviour
{
    public SpawnSemiminime spawnSem;
    public ScoreManager sm;
    public int noteCount;

    // Update is called once per frame
    void Update()
    {

    }
    //reso pubblico temporaneamente per poterlo richiamare in spawn semi
    //public void OnTriggerEnter2D(Collider2D collision)
    //{
       // if (collision.tag == "Player")
        //    Debug.Log("collisione avvenuta ye");
        //if (collision.tag == "Border")
       // {
        //  Destroy(this.gameObject);
       //  }
        //DECOMMENTA FINO A QUI





        //collisione con player
        //if (collision.tag == "Player")
        // Debug.Log("collisione avvenuta ye");

        //{
        //  sm.noteCount++;
        //Debug.Log("puntino");

        //sm.AddPoint();
        //  Destroy(this.gameObject);
        // Debug.Log("oggetto distrutto");
        //}


        //if (collision.tag == "Player" && spawnSem.textObject.tag == spawnSem.note1.tag))
        //{
        //  Debug.Log("yo");


        //} else {
        //  Debug.Log("no");
    //}


    internal void OnTriggerEnter2D()
    {
        if (gameObject.CompareTag("Player"))
            Debug.Log("collisione avvenuta ye");
        {
            Destroy(this.gameObject);
        }
        throw new NotImplementedException();
   }



}




