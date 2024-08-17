using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFruitCollision : MonoBehaviour
{
    public GameObject nextFruit;
    public void OnCollisionEnter2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == this.gameObject.tag)
        {
            Destroy(this.gameObject);   
            Destroy(collision.gameObject);
            if (this.gameObject.GetInstanceID() < collision.gameObject.GetInstanceID())
            {
                Instantiate(nextFruit, transform.position, Quaternion.identity);
            }
        }
    }
}
