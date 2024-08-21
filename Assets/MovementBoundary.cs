using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBoundary : MonoBehaviour
{
    [SerializeField] private Transform parentTransform;
    // Start is called before the first frame update
    void Start()
    {
        parentTransform = transform.parent;
    }
    // Update is called once per frame
    void Update()
    {
        //Transform transformParent = transform.parent; 

        if (parentTransform.position.x >= 10) parentTransform.position = new Vector2(10, parentTransform.position.y);
        if (parentTransform.position.x <= -4) parentTransform.position = new Vector2(-4, parentTransform.position.y);
    }
}
