using UnityEngine;


public class coinDestroy : MonoBehaviour
{
    private static int score;
    public GameManager manager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destroy coin upon player trigger collision
    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))
        {

            Destroy(gameObject);
            manager.addscore(1);

        }

    }

}