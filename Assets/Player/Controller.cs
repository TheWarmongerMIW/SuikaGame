using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private KeyCode LeftKey = KeyCode.A;
    [SerializeField] private KeyCode RightKey = KeyCode.D;
    [SerializeField] private float speed = 1.0f;    

    public Rigidbody2D body;

    void Start()
    {
        
    }

    /*private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.y = 10f;
        transform.position = mousePos;  
    }*/
    void FixedUpdate()
    {
        if (Input.GetKey(LeftKey)) body.MovePosition(body.position + new Vector2(-1,0) * speed * Time.fixedDeltaTime);
        if (Input.GetKey(RightKey)) body.MovePosition(body.position + new Vector2(1,0) * speed * Time.fixedDeltaTime);
    }
}
