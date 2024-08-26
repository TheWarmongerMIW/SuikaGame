using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private KeyCode LeftKey = KeyCode.A;
    [SerializeField] private KeyCode RightKey = KeyCode.D;
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private bool isUsingKeyboard = false;
    [SerializeField] private bool isUsingMouse = false;

    public Rigidbody2D body;

    void Start()
    {
        isUsingKeyboard = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        { 
            isUsingKeyboard = true; 
            isUsingMouse = false; 
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            isUsingMouse = true;
            isUsingKeyboard = false;
        }
    }
    void FixedUpdate()
    {
        Keyboard();
        Mouse();
    }

    private void Keyboard()
    {
        if (isUsingKeyboard)
        {
            if (Input.GetKey(LeftKey)) body.MovePosition(body.position + new Vector2(-1, 0) * speed * Time.fixedDeltaTime);
            if (Input.GetKey(RightKey)) body.MovePosition(body.position + new Vector2(1, 0) * speed * Time.fixedDeltaTime);
        }
    }
    private void Mouse()
    {
        if (isUsingMouse)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.y = -9.15704f;
            mousePos.x = Mathf.Clamp(mousePos.x, -3.7f, 10.13f);

            body.MovePosition(mousePos);
        }
    }
}
