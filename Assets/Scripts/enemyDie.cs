using UnityEngine;

public class enemyDie : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Death Barrier"))
        {

            die();

        }

    }

    void die()
    {

        Debug.Log("Enemy died!");
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
