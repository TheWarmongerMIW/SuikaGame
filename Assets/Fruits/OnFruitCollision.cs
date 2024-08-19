using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFruitCollision : MonoBehaviour
{
    public GameObject nextFruit;
    [SerializeField] private Score score;

    private void Start()
    {
        score = GameObject.Find("Point Bubble").GetComponent<Score>(); 
    }

    private void Update()
    {
        //AddScore();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == this.gameObject.tag)
        {
            Destroy(this.gameObject);   
            Destroy(collision.gameObject);
            if (this.gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                Instantiate(nextFruit, transform.position, Quaternion.identity);
                AddScore();
            }
        }
    }

    public void AddScore()
    {
        if (nextFruit.gameObject.tag == "Strawberry") score.AddScore(3); 
        if (nextFruit.gameObject.tag == "Grape") score.AddScore(6); 
        if (nextFruit.gameObject.tag == "Lemon") score.AddScore(10); 
        if (nextFruit.gameObject.tag == "Orange") score.AddScore(15); 
        if (nextFruit.gameObject.tag == "Apple") score.AddScore(21); 
        if (nextFruit.gameObject.tag == "Pear") score.AddScore(28); 
        if (nextFruit.gameObject.tag == "Banana") score.AddScore(36); 
        if (nextFruit.gameObject.tag == "Pineapple") score.AddScore(45); 
        if (nextFruit.gameObject.tag == "Watermelon") score.AddScore(55); 
    }
}
