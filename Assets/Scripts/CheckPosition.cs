using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPosition : MonoBehaviour
{
    [SerializeField] GameObject PositionChecker;
    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Nota"))
        {
            Debug.Log("collisione con game object vuoto");
        }
    }
}