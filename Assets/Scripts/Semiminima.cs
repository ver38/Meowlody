using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SpawnSemiminime spawnSem;
    public ScoreManager sm;
    public int noteCount;

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }


        //collisione con players
        if (collision.tag == "Player")
            Debug.Log("collisione avvenuta ye");

        {
            // sm.AddPoint();
            Destroy(this.gameObject);
            Debug.Log("oggetto distrutto");
        }

        //if (collision.tag == "Player" && spawnSem.textObject.tag == spawnSem.note1.tag))
        //{
          //  Debug.Log("yo");
                

            //} else {
              //  Debug.Log("no");
                    }
            // fine if else
        //}
    }

    

