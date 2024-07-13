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

    public void ReloadScene()
    {
        StartCoroutine("ReloadSceneWait");
    }

    public void LoadNextScene()
    {
        StartCoroutine("LoadNextSceneWait");
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(LoadSceneWait(sceneName));
    }

    public void QuitGame()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    private IEnumerator ReloadSceneWait()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(_currentScene.buildIndex);
    }

    private IEnumerator LoadNextSceneWait()
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(_currentScene.buildIndex + 1);
    }

    private IEnumerator LoadSceneWait(string name)
    {
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(name);
    }
}
