using UnityEngine;
using UnityEngine.SceneManagement;

public class crashdetector : MonoBehaviour
{
    CircleCollider2D headCollider;

    void Start()
    {
        headCollider = GetComponent<CircleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground"))
        {
            if (collision.otherCollider == headCollider)
            {
                Invoke("reloadScene", 0.7f);
            }
        }
    }
    void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
