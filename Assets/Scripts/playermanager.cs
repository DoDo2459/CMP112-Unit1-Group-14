using UnityEngine;

public class playermanager : MonoBehaviour
{
    public GameManager manager;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find game manager object
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //kills player and calls game over screen
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Spike"))
        {

            manager.gameOverScreenOn();
            Debug.Log("Player died!");
            Destroy(gameObject);
            

        }
        //kills player and call game win screen
        if (collision.gameObject.CompareTag("Win"))
        {
            manager.gameWinScreenOn();
            Debug.Log("Player win");
            Destroy(gameObject);
        }

    }

    
}
