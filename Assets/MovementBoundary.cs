using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 10) transform.position = new Vector2(10, transform.position.y);
        if (transform.position.x <= -4) transform.position = new Vector2(-4, transform.position.y);
    }
}
