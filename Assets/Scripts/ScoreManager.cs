using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public int noteCount;
    public Text noteText;
    //public string currentNoteTag;
    //public TextArrayBuilder arbuild; 
    // Start is called before the first frame update
    void Start()
    {
       // currentNoteTag = ""; 

    }

    // Update is called once per frame
    void Update()
        
        //questo update è solo per contare, quindi notecount e notetext devono rimanere non ti scordare
        // l unica aggiunta è public string currentnotetag per provare a confrontare i tag nelle collisioni
    {
       // arbuild.SetCurrentNoteTag();

        noteText.text = noteCount.ToString();

    }
}
