using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;
    

    void Start()
    {
        
    }
    //score keeper
    public void addscore(int scoretoAdd)
    {
        playerScore = playerScore + scoretoAdd;
        scoreText.text = playerScore.ToString();
        
    }
    
    //initialize game over screen
    public void gameOverScreenOn()
    {
        Debug.Log("PlayerGameOver");
        gameOverScreen.SetActive(true);
    }
    //initialize win game screen
    public void gameWinScreenOn()
    { 
        gameWinScreen.SetActive(true);
    }
    //restarts game
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
