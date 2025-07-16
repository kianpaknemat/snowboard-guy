using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        string lastScene = PlayerPrefs.GetString("LastLevelName", "Level 1");
        SceneManager.LoadScene(lastScene);
    }


    public void OpenOptions()
    {
        Debug.Log("Options menu opened (not implemented yet)");
    }

    public void QuitGame()
    {
        Debug.Log("Game is quitting...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
