using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class NextFruit : MonoBehaviour
{
    [SerializeField] private SpawnFruit spawnFruit;
    [SerializeField] private Image image; 

    void Start()
    {
        spawnFruit = GameObject.Find("Spawner").GetComponent<SpawnFruit>(); 
    }

    void Update()
    {
        if (spawnFruit.isNextFruitSelected)
        {
            Sprite fruitSprite = spawnFruit.nextSelectedFruit.GetComponent<SpriteRenderer>().sprite;
            image.sprite = fruitSprite;
        }
    }
}
