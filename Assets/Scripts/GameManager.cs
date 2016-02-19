using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    [SerializeField]
    private int lives = 3;
    [SerializeField]
    private int score = 0;
    [SerializeField]
    private Text ScoreText;
    [SerializeField]
    private Image Life1;
    [SerializeField]
    private Image Life2;
    [SerializeField]
    private Image Life3;

    public void AddScore(int score)
    {
        this.score += score;
        ScoreText.text = "Score: " + this.score;
    }

    public void PlayerDead()
    {
        lives--;
    }

}
