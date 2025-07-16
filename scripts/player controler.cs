using UnityEngine;
using UnityEngine.InputSystem;

public class playercontroler : MonoBehaviour
{
    [SerializeField] float torqueamount = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(-torqueamount);
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            rb.AddTorque(torqueamount);
        }
    }
}
