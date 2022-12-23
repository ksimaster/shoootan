using UnityEngine;
using UnityEngine.UI;

public class updatescore : MonoBehaviour
{
    public Text score;
    public Text highscore;
    public Text highscore2;

    public int score_count = 0;
    private void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
    public void ChangeScore()
    {
        score_count++;
        score.text = score_count.ToString();
    }
    public void UpdateHighScore()
    {
        if (score_count > PlayerPrefs.GetInt("HighScore"))
        { 
            highscore.text = score_count.ToString();
            highscore2.text = score_count.ToString();
            PlayerPrefs.SetInt("HighScore", score_count);
        }
        else
        {
            highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
            highscore2.text = PlayerPrefs.GetInt("HighScore").ToString();
        }
    }
}
