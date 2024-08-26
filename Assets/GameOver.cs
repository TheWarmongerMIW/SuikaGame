using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;
using Unity.VisualScripting;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Image fadePanel;
    [SerializeField] private float fadeSpeed = 2f;
    [SerializeField] private UnityEvent GameOverScreen;
    [SerializeField] private bool isGameOver = false;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            StartCoroutine(GameOverFadeIn());   
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameOverScreen.Invoke();
        isGameOver = true;  
    }

    private IEnumerator GameOverFadeIn()
    {
        fadePanel.gameObject.SetActive(true);

        Color startColor = fadePanel.color;
        startColor.a = 0f;
        fadePanel.color = startColor;

        float elaspedTime = 0f;
        while (elaspedTime < fadeSpeed)
        {
            elaspedTime += Time.deltaTime;

            float newAlpha = Mathf.Lerp(0f, 1f, (elaspedTime / fadeSpeed));
            startColor.a = newAlpha;
            fadePanel.color = startColor;

            yield return null;
        }

        SceneManager.LoadScene(0);
    }
}
