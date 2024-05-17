using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panels : MonoBehaviour
{
    [SerializeField] GameObject arrowTutorial;
    // Start is called before the first frame update
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        arrowTutorial.SetActive(true);

    }
}
