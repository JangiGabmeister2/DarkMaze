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
        SceneManager.LoadScene(_currentScene.buildIndex);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(_currentScene.buildIndex + 1);
    }
}
