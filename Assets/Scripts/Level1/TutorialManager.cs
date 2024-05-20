using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public bool isTutorialFinished = false;


    public Text tutorialText;
    public Button nextButton;
    public GameObject tutorialPanel;
    private int currentStep = 0;

    private readonly string[] tutorialSteps = new string[]
    {
        "Welcome to Meowlody's journey. Slide up and down to take the correct note.",
        "Take the note shown in the box below. Only one note will appear at a time during the tutorial!",
        "Each time you take the correct note, you will get +1.",
        "Avoid the wrong note to keep your health full. During the tutorial, you will have infinite health.",
        "Taste the spiral candy: something may change :)",
        "When you feel confident, tap the PLAY button to enter the game. Have fun!"

    };

    void Start()
    {
        ShowStep();
        nextButton.onClick.AddListener(NextStep);
    }

    public void ShowStep()
    {
        if (currentStep < tutorialSteps.Length)
        {
            tutorialText.text = tutorialSteps[currentStep];
        }
        else
        {
            EndTutorial();
        }
    }

    public void NextStep()
    {
        Debug.Log("Bottone premuto!"); // Aggiungi questa linea per verificare

        currentStep++;
        ShowStep();
    }

    void EndTutorial()
    {
        tutorialText.text = "Tutorial completed!";
        nextButton.gameObject.SetActive(false);
        tutorialText.gameObject.SetActive(false);
        tutorialPanel.gameObject.SetActive(false);
        isTutorialFinished = true;
        Debug.Log("ASDRUBALE " + isTutorialFinished);


    // Aggiungi ulteriori azioni, come iniziare il gioco.
}
}
