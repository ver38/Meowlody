using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public AudioSource audioPlayer;

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public ScoreManager sm;
    public SpawnManager spawnman;
    public DamagePlayer dm;


    private bool isTouching = false;
    private Vector2 touchStartPosition;
    private Vector2 lastTouchPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;


            
            transform.position = new Vector3(transform.position.x, touchPosition.y, transform.position.z);
        }
        else
        {
            float directionY = Input.GetAxisRaw("Vertical");
            rb.velocity = new Vector2(0, directionY * playerSpeed);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Nota"))

        {
            sm.AddToScore();
            audioPlayer.Play();
             Debug.Log("nuovo score " + sm.currentScore);

            Destroy(other.gameObject);
           // spawnman.NoteNameChanges();
            //Debug.Log(" mostro nome solo su collisione");

            //  Debug.Log("collisione con nota amica");
        }


        else if
             (other.gameObject.CompareTag("WrongNote"))
        {


            Destroy(other.gameObject);
            //spawnman.NoteNameChanges();
            dm.DecreaseHealth(1);
            // Debug.Log("nota nemica toccata, -1 vite");
        }


    }

}
