using UnityEngine;
using UnityEngine.SceneManagement;

public class crashdetector : MonoBehaviour
{
    CircleCollider2D headCollider;
    [SerializeField] AudioClip crashSFX;
    bool hasCrash = false;

    void Start()
    {
        headCollider = GetComponent<CircleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground") && !hasCrash)
        {
            if (collision.otherCollider == headCollider)
            {
                hasCrash = true;
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                Invoke("reloadScene", 1.5f);
            }
        }
    }
    void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
