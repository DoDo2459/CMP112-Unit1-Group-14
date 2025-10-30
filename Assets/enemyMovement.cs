using UnityEngine;

public class enemyMovement : MonoBehaviour

{

    public float speed;
    private float direction = -1;
    private Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()

    {

        //Move the enemy horizontally
        Vector2 movement = new Vector2(direction, 0);
        rb.linearVelocity = new Vector2(direction * speed, rb.linearVelocity.y);

    }

    void OnCollisionEnter2D(Collision2D collision)

    {

        // Reverse direction when hitting anything
        direction *= -1;

    }

}