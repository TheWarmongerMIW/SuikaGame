using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreCount;
    void Start()
    {
        scoreCount = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateScore(Score score)
    {
        scoreCount.text = score.ScoreToAdd.ToString();
    }
}
