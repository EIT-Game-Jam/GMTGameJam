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

    private Vector2 movement;
    private bool used = false;
    private bool shift = false;
    public bool ifTwoPlayer = false;

    private bool justShifted = false;


    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        Debug.Log(this.gameObject.name + ": " + movement);

    }

    public void OnUse(InputAction.CallbackContext context)
    {
        
    }

    public void OnShift(InputAction.CallbackContext context)
    {
        if(ifTwoPlayer == false)
        {
        shift = context.action.triggered;
        if(shift == true && justShifted == false){

            Debug.Log(this.gameObject.name + ": " + shift);
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            
            GetComponent<PlayerMovement>().enabled = false;
            
            
        }
        }
    }


    public void OnEnable()
    {
        justShifted = true;

    }


    public void TwoPlayer(InputAction.CallbackContext context)
    {
      
    }

    void awake()
    {
        used = false;
        shift = false;

        
    }

    void Start()
    {

        
        if(this.gameObject.name == "Tomato(Clone)")
        {
            otherPlayer = GameObject.Find("Cucumber(Clone)");
        }
        else
        {
            otherPlayer = GameObject.Find("Tomato(Clone)");
        }


    }

    // Update is called once per frame
    void Update()
    {
        //input
       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.magnitude);
       
       
        if(shift == false)
        {
            justShifted = false;
        }

    }



    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
