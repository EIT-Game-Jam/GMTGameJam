using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private Rigidbody2D rb;


    Vector2 movement;


    public void OnMove(InputAction.CallbackContext context)
    {
         movement = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        //input
    }



    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
