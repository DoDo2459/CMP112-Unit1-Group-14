using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public float speed;
    private float direction = -1;

    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = direction;

        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.AddForce(movement * speed);
    }
}
