using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Scene _currentScene;

    private void Start()
    {
        _currentScene = SceneManager.GetActiveScene();
    }

    public void ReloadScene(float waitTime)
    {
        StartCoroutine(ReloadSceneWait(waitTime));
    }

    public void LoadNextScene(float waitTime)
    {
        StartCoroutine(LoadNextSceneWait(waitTime));
    }

    private IEnumerator ReloadSceneWait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(_currentScene.buildIndex);
    }

    private IEnumerator LoadNextSceneWait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(_currentScene.buildIndex + 1);
    }
}
