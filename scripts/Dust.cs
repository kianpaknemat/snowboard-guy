using UnityEngine;

public class Dust : MonoBehaviour
{
    [SerializeField] ParticleSystem dust;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            {
                dust.Play();
            }
        }
    }


    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            {
                dust.Stop();
            }
        }
    }
}
