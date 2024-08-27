using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFruitCollision : MonoBehaviour
{
    [SerializeField] private Score score;
    [SerializeField] private bool isLocked = false;
    [SerializeField] private CollidedFruit collidedFruit;
    
    public GameObject nextFruit;
    private void Start()
    {
        score = GameObject.Find("Point Bubble").GetComponent<Score>();
    }

    private void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    { 
        CollidedFruit collidedFruit = collision.gameObject.GetComponent<CollidedFruit>();   
        if (collision.gameObject.GetComponent<CollidedFruit>().ID == this.gameObject.GetComponent<CollidedFruit>().ID && !this.isLocked && !collidedFruit.isLocked)
        {
            collidedFruit.isLocked = true;
            this.isLocked = true;

            Destroy(this.gameObject);   
            Destroy(collision.gameObject);

            Vector2 spawnPosition = (this.transform.position + collision.transform.position) / 2;

            if (this.gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                Instantiate(nextFruit, spawnPosition, Quaternion.identity);
                AddScore();
            }
        }

        StartCoroutine(UnlockFruit());  
    }

    public void AddScore()
    {
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Strawberry") score.AddScore(3); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Grape") score.AddScore(6); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Lemon") score.AddScore(10); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Orange") score.AddScore(15); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Apple") score.AddScore(21); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Pear") score.AddScore(28); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Banana") score.AddScore(36); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Pineapple") score.AddScore(45); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Watermelon") score.AddScore(55); 
        if (nextFruit.gameObject.GetComponent<CollidedFruit>().ID == "Infinity") score.AddScore(100);
    }

    private IEnumerator UnlockFruit()
    {
        yield return new WaitForSeconds(0.75f);
        isLocked = false;
        collidedFruit.isLocked = false; 
    }
}
