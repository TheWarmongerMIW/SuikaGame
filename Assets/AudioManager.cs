using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource Pop;
    [SerializeField] private OnFruitCollision onFruitCollision;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*GameObject[] fruits = GameObject.FindGameObjectsWithTag("New Fruit");  
        foreach (GameObject fruit in fruits)
        {
            OnFruitCollision onFruitCollision = fruit.GetComponent<OnFruitCollision>();
            if (onFruitCollision.addedScore)
            {
                Pop.Play();
                Debug.Log("Pop sound Played");
            }
        }*/
    }
}
