using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevel1 : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public ScoreLevel1 slvl;
    public SpawnMiniCookie smc;

    //public SpawnManagerTutorial spawnmant;

    // private bool isTouching = false;
    //private Vector2 touchStartPosition;
    //private Vector2 lastTouchPosition;

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
            slvl.AddToScore();
            Debug.Log("nuovo score " + slvl.currentScoreValueLvl);

            Destroy(other.gameObject);
            //  Debug.Log("collisione con nota amica");
        }

        else if (other.gameObject.CompareTag("spiral"))

        {
            smc.IsCookieHit();
            Debug.Log("cambio valore var " + smc.cookieIsEaten);
            Destroy(other.gameObject);
        }
    }

}
