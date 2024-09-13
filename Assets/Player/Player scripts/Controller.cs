using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody2D body;

    void Start()
    {

    }

    private void Update()
    {
        
    }
    void FixedUpdate()
    { 
        Mouse();
    }

    private void Mouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = -9.15704f;
        mousePos.x = Mathf.Clamp(mousePos.x, -3.7f, 10.13f);
        
        body.MovePosition(mousePos);
    }
}
