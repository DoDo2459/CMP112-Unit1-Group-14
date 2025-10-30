using UnityEngine;

public class playerDie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Spike"))
        {

            die();

        }

    }

    void die()
    {

        Debug.Log("Player died!");
        Destroy(gameObject);

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
