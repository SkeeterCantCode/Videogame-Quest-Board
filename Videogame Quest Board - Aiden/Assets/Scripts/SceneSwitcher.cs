using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;
    public void goToQuestboard()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void goHome()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex - 1));
    }

    IEnumerator LoadScene(int levelIndex)
    {
        ///Play our animation
        transition.SetTrigger("Start");

        ///Wait
        yield return new WaitForSeconds(transitionTime);

        ///LoadScene
        SceneManager.LoadScene(levelIndex);
    }
}
