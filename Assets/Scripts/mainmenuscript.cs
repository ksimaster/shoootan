using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class mainmenuscript : MonoBehaviour
{
    public Text highScoreRef;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //if(PlayerPrefs.HasKey("HighScore"))
            highScoreRef.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void PlayButtonClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButtonClicked()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    public void ResetHighScoreButtonClicked()
    {
        Debug.Log("Highscore is Reset");
        highScoreRef.text = "0";
        PlayerPrefs.DeleteAll();
    }

}
