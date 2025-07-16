using UnityEngine;
using UnityEngine.SceneManagement;

public class finishLine : MonoBehaviour
{
    string level;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            string numberStr = System.Text.RegularExpressions.Regex.Match(currentSceneName, @"\d+$").Value;

            if (int.TryParse(numberStr, out int levelNumber))
            {
                int nextLevel = levelNumber + 1;
                level = "level " + nextLevel;
                Debug.Log("Loading: " + level);

                if (Application.CanStreamedLevelBeLoaded(level))
                {
                    Invoke(nameof(reloadScene), 0.7f);
                }
                else
                {
                    Debug.Log("صحنه بعدی وجود نداره: " + level);
                }
            }
        }
    }

    void reloadScene()
    {
        PlayerPrefs.SetString("LastLevelName", level);
        PlayerPrefs.Save();
        SceneManager.LoadScene(level);
    }
}
