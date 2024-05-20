using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 1f;

    public void ChangeScene()
    {
        StartCoroutine(LoadLevel());
        //SceneManager.LoadSceneAsync(1);
    }

    IEnumerator LoadLevel()
    //IEnumerator LoadLevel(int levelIndex)

    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(2);


    }
}
