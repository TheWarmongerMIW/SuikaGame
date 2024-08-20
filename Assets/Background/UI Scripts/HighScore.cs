using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Events;
using UnityEngine;
using Unity.VisualScripting;

public class HighScore : MonoBehaviour
{   
    public TextMeshProUGUI highScore;
    public Score score;
    public ScoreCount scoreCount;
    
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); 
    }

   
    void Update()
    {
        AddHighScore();
        if (Input.GetKey(KeyCode.R)) ResetHighScore();    
    }

    public void AddHighScore()
    {
        if (score.ScoreToAdd > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score.ScoreToAdd);
            highScore.text = score.ScoreToAdd.ToString();   
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
