using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text ScoreText;
    private int score;

    public AudioSource sfxCorrect;
    //public GameObject gameScreen;
    public GameObject endScreen;
    
    void Start()
    {
        score = 0;
        ScoreText.text = "Score:" + score;
    }

    void EndGame()
    {
        //gameScreen.SetActive(false);
        SceneManager.LoadScene("Scenes/endGame");
    }

    public void UpdateScore(int scoreToAdd)
    {
        sfxCorrect.Play();
        score += scoreToAdd;
        ScoreText.text = "Score:" + score;
        if (score == 6)
        {
            EndGame();
        }
    }
}
