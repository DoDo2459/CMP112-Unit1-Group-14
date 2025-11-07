using UnityEngine;


public class coinDestroy : MonoBehaviour
{
    private static int score;

    //Audio variables
    private AudioSource source;
    public AudioClip CoinSound;

    public GameManager manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destroy coin upon player trigger collision and call add score function
    private void OnTriggerEnter2D(Collider2D other)

    {

        if (other.CompareTag("Player"))
        {

            source.PlayOneShot(CoinSound, 1.0f);
            Destroy(gameObject);
            manager.addscore(1);


        }

    }

}