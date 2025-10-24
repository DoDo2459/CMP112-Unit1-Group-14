using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2 (moveHorizontal, 0);
        rb.AddForce(movement * speed);
    }

    
}
