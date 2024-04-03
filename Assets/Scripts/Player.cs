using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public ScoreManager sm;
    //public SpawnSemiminime spawnSem;
    public TextArrayBuilder tab;

    private bool isTouching = false;
    private Vector2 touchStartPosition;
    private Vector2 lastTouchPosition;

    //AudioManager audioManager;
    //ok rompe il touch
    //private void Awake()
    //{
      //  audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    //}



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


        //collisione con minicookie
        if (other.gameObject.CompareTag("Cookie"))
        {
            //audio se rompe il gioco lo levi da qua e levi sopra audiomanager e awake
            // ok rompe la collisione
            //audioManager.PlaySFX(audioManager.cookie);

            Destroy(other.gameObject);

            sm.AddPoint();
        }
    }

}
