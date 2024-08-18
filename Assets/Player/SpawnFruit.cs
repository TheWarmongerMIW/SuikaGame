using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    [SerializeField] private KeyCode spawnKey = KeyCode.Space;
    [SerializeField] private float spawnRate;
    [SerializeField] private float lastSpawnTime;
    [SerializeField] private List<GameObject> fruits = new List<GameObject>();
    [SerializeField] private Rigidbody2D fruitBody;
    [SerializeField] private Collider2D fruitCollider;
    [SerializeField] private Transform spawner;
    [SerializeField] private GameObject selectedFruit;
    [SerializeField] private bool isSelected = false;
    [SerializeField] private bool isDone = false;
    
    public GameObject nextSelectedFruit;  
    public bool isNextFruitSelected = false;

    private void Start()
    {
        NextFruit();

        int randomNumber = Random.Range(1, fruits.Count + 1);
        selectedFruit = fruits[randomNumber - 1];

        GameObject instantiatedFruit = Instantiate(selectedFruit, transform.position, transform.rotation, spawner);
        instantiatedFruit.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        fruitBody = instantiatedFruit.GetComponent<Rigidbody2D>();
        fruitCollider = instantiatedFruit.GetComponent<CircleCollider2D>();

        fruitBody.bodyType = RigidbodyType2D.Kinematic;
        fruitCollider.enabled = false;

        lastSpawnTime = Time.time;
        isDone = false;
    }
    void Update()
    {
        if (Time.time > spawnRate + lastSpawnTime && !isSelected) FruitSpawner();
        if (Time.time > spawnRate + lastSpawnTime && !isNextFruitSelected) NextFruit(); 

        if (Input.GetKeyDown(spawnKey))
        {
            if (Time.time > spawnRate + lastSpawnTime)
            {
                fruitBody.bodyType = RigidbodyType2D.Dynamic;
                fruitCollider.enabled = true;
                lastSpawnTime = Time.time;
                isSelected = false;
                isNextFruitSelected = false;
                isDone = true;
            }
        }
    }
    public void FruitSpawner()
    {
        //int randomNumber = Random.Range(1, fruits.Count + 1);
        //selectedFruit = fruits[randomNumber - 1];
        selectedFruit = nextSelectedFruit;

        if (isDone)
        {
            GameObject instantiatedFruit = Instantiate(selectedFruit, transform.position, transform.rotation, spawner);
            instantiatedFruit.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

            fruitBody = instantiatedFruit.GetComponent<Rigidbody2D>();
            fruitCollider = instantiatedFruit.GetComponent<CircleCollider2D>();

            fruitBody.bodyType = RigidbodyType2D.Kinematic;
            fruitCollider.enabled = false;

            isSelected = true;
        }
    }

    public void NextFruit()
    {
        int randomNextFruit = Random.Range(1, fruits.Count + 1);
        nextSelectedFruit = fruits[randomNextFruit - 1];

        isNextFruitSelected = true;
    }
}
