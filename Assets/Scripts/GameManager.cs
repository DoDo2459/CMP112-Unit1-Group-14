using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;

    private void Start()
    {
        playerScore = 0;
    }
    public void addscore(int scoretoAdd)
    {
        playerScore = playerScore + scoretoAdd;
        scoreText.text = playerScore.ToString();
        
    }
    
    public void gameOverScreenOn()
    {
        Debug.Log("PlayerGameOver");
        gameOverScreen.SetActive(true);
    }
    public void gameWinScreenOn()
    { 
        gameWinScreen.SetActive(true);
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
