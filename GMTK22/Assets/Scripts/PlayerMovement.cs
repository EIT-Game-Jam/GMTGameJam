using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    public GameObject otherPlayer;
    private bool activePlayer = false;
    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;
    private bool used = false;
    private bool shift = false;
    public bool ifTwoPlayer = false;


    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        Debug.Log(movement);

    }

    public void OnUse(InputAction.CallbackContext context)
    {
        
    }

    public void OnShift(InputAction.CallbackContext context)
    {
        if(ifTwoPlayer == false)
        {
        shift = context.action.triggered;
        if(shift){
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            GetComponent<PlayerMovement>().enabled = false;
            
        }
        }
    }


    public void TwoPlayer(InputAction.CallbackContext context)
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //input
        /*
       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.magnitude);
       */
    }



    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
