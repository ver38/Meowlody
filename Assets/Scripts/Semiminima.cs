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


        //collisione con player
        if (collision.tag == "Player")

        {
            sm.AddPoint();
            Destroy(this.gameObject);
           

        }
    }

    
}
