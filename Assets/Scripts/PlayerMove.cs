using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMove : MonoBehaviour
{
    private bool isGrounded = false;
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.AddForce(movement * speed);
        if (Keyboard.current.wKey.isPressed && isGrounded)
        {
            Debug.Log("Jump");
            Vector2 jump = new Vector2 (0, jumpForce);
            rb.AddForce(jump, ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.layer == 8 && !isGrounded)
        {
            isGrounded = true;
            Debug.Log("Grounded is true");
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8 && isGrounded)
        {
            isGrounded = false;
        }
    }

}
