using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    [SerializeField] private KeyCode spawnKey = KeyCode.Space;
    [SerializeField] private float spawnRate;
    [SerializeField] private float lastSpawnTime;

    public List<GameObject> fruits = new List<GameObject>();    
    public Transform spawner;
    public GameObject selectedFruit;
    public bool isSelected = false;

    void Update()
    {
        if (!isSelected)
        {
            int randomNumber = Random.Range(1, fruits.Count + 1);
            selectedFruit = fruits[randomNumber - 1];

            isSelected = true;  
        }

        if (Input.GetKeyDown(spawnKey))
        {
            if (Time.time > spawnRate + lastSpawnTime)
            {
                Instantiate(selectedFruit, transform.position, transform.rotation);
                lastSpawnTime = Time.time;
                isSelected = false;
            }
        }
    }
}
