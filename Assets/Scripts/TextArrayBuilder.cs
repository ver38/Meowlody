using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextArrayBuilder : MonoBehaviour
{
    public GameObject noteTextContainer;
    public Text[] textArray;
    //public string currentNoteTag;

    void Start()
    {
        Text[] allTextObjects = GetComponentsInChildren<Text>();

        textArray = new Text[allTextObjects.Length];

        for (int i = 0; i < allTextObjects.Length; i++)
        {
            textArray[i] = allTextObjects[i];
        }


        int randomIndex = Random.Range(0, textArray.Length);
        textArray[randomIndex].gameObject.SetActive(true);

        for (int i = 0; i < textArray.Length; i++)
        {
            if (i != randomIndex) // disattiva tutti i testi tranne quello selezionato casualmente
            {
                textArray[i].gameObject.SetActive(false);
            }
        }

        //SetCurrentNoteTag();
    }
    //tutta roba messa mo in prova, se non funziona rimuovi tutte le reference a currentnotetag anche da sopra e dagli altri script
    //private void SetCurrentNoteTag()
    //{
      //  throw new System.NotImplementedException();
    //}

//    public void SetCurrentNoteTag(string tag)
  //  {
    //    currentNoteTag = tag;
    //}

}  