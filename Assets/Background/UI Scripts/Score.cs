using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private UnityEvent<Score> IncreaseScore;
    
    public int ScoreToAdd;

    private void Start()
    {
        ScoreToAdd = 0; 
    }

    public void AddScore(int amount)
    {
        ScoreToAdd += amount;
        IncreaseScore.Invoke(this);
    }
}
