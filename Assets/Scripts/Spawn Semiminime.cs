using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSemiminime : MonoBehaviour
{
    public GameObject semiminima;
    public float maxX;
    public float minX;
    public GameObject axisContainer;
    public GameObject[] noteTextContainer;

    public static TextArrayBuilder textarraybuild;
    public Player player;
    public ScoreManager sm;
    public Semiminima scriptPrefab;

    public float timeBetweenSpawn;
    private float spawnTime;

    public GameObject note1;
    public GameObject note2;

    public GameObject selectedText = null;
    public GameObject textObject = null;

    public int points = 2;



    void Start()
    {

        spawnTime = Time.time + timeBetweenSpawn;

    }

    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
            //CompareTags();
        }
    }

    public void Spawn()
    {
        Transform[] spawnAxes = GetAxesFromContainer();
        //null check
        if (spawnAxes.Length < 2)
        {
            Debug.LogWarning("container is empty");
            return;
        }
        //prendo due assi random su cui spawnare
        Transform axis1 = spawnAxes[Random.Range(0, spawnAxes.Length)];
        Transform axis2 = axis1;
        while (axis2 == axis1)
        {
            axis2 = spawnAxes[Random.Range(0, spawnAxes.Length)];
        }

        Vector3 axis1Position = axis1.position;
        Vector3 axis2Position = axis2.position;

        // qui calcolo la distanza tra gli assi con una soglia minima
        float distanceBetweenAxes = Vector3.Distance(axis1Position, axis2Position);
        float minDistanceBetweenAxes = 1.0f;

        // se la distanza tra gli assi è < di mindistance, non spawna
        //però così a volte non spawna e resta un vuoto sul pentagramma 
        if (distanceBetweenAxes < minDistanceBetweenAxes)
        {
            Debug.LogWarning("assi troppo vicini per spawnare");
            return;
        }

        float randomX1 = Random.Range(minX, maxX);
        float randomX2 = Random.Range(minX, maxX);


        // NON CAMBIARE QUESTO PER NESSUNA RAGIONE AL MONDO VERONICA 
        GameObject note1 = Instantiate(semiminima, new Vector3(axis1Position.x + Random.Range(minX, maxX), axis1Position.y, axis1Position.z), Quaternion.identity);
        GameObject note2 = Instantiate(semiminima, new Vector3(axis2Position.x + Random.Range(minX, maxX), axis2Position.y, axis2Position.z), Quaternion.identity);

        note1.tag = axis1.tag;
        note2.tag = axis2.tag;

        // controlla se il tag delle note = tag degli assi, NON TOCCARE PIU NIENTE
        if (axis1.CompareTag(note1.tag) && axis2.CompareTag(note2.tag))
        {
            Debug.Log("tag assi-note assegnati correttamente");
        }

        // prendo un testo a caso tra i due associati al tag delle due note
        // GameObject selectedText = null;
        foreach (GameObject textObject in noteTextContainer)
        {
            if (textObject.CompareTag(note1.tag) || textObject.CompareTag(note2.tag))
            {
                selectedText = textObject;
                //break;
            }
        }

        //prendo il tag da passarmi nello script della collisione della nota
        //selectedText.tag = note1.tag;
        //string selectedTextTag = selectedText.tag;
        //Debug.Log("vedo tag di selectedText: " + selectedTextTag);

        //selectedText.tag = note1.tag;
        //Debug.Log("vedo i due tag: " + selectedTextTag + note1.tag);

        // disattiva tutti i testi tranne quello selezionato
        foreach (GameObject textObject in noteTextContainer)
        {
            textObject.SetActive(textObject == selectedText);
        }



        // spawno il testo selezionato
        if (selectedText != null)
        {
            Instantiate(selectedText, selectedText.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("non ci sono testi associati al tag delle note");
        }

        selectedText.tag = note1.tag;
        string selectedTextTag = selectedText.tag;
        Debug.Log("vedo tag di selectedText: " + selectedTextTag);

        //selectedText.tag = note1.tag;
        Debug.Log("vedo i due tag: " + selectedTextTag + note1.tag);

        if (selectedText.tag == note1.tag)
        // AddPointsToScore();

        {


            // AddPointsToScore();
            Debug.Log("tag del testo e tag nota sono uguali");
        }
        else
        {
            Debug.Log("i tag sono diversi");
        }
    }


   // public void CompareTags()
    //{
        //comparo il tag del testo spawnato col tag delle note
    //    if (selectedText.tag != note1.tag)
            // AddPointsToScore();

      //  {


            // AddPointsToScore();
        //    Debug.Log("tag del testo e tag nota sono uguali");
       // }
       // else
       // {
         //   Debug.Log("i tag sono diversi");
       // }
   // }


    private void AddPointsToScore()
    {
       // sm.AddPoint();
    }

    Transform[] GetAxesFromContainer()
    {
        if (axisContainer != null)
        {
            Transform[] axes = new Transform[axisContainer.transform.childCount];
            for (int i = 0; i < axisContainer.transform.childCount; i++)
            {
                axes[i] = axisContainer.transform.GetChild(i);
            }
            return axes;
        }
        else
        {
            Debug.LogError("could not find axis container");
            return new Transform[0];
        }
    }

}