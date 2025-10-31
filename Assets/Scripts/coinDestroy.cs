using UnityEngine;
using UnityEngine.UI;

public class coinDestroy : MonoBehaviour
{
    private static int score;
    public Text scoreUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
            //update score
            score++;
            scoreUI.text = score.ToString();

        }

    }

}