using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsPanelOpensUp : MonoBehaviour
{

    public GameObject CreditsPanel;

    public void OpenPanel()
    {

        if (CreditsPanel != null)
        {
            CreditsPanel.SetActive(true);
                }
    }

    public void ClosePanel()
    {
        CreditsPanel.SetActive(false);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
