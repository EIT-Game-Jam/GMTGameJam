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
    public bool used = false;
    private bool shift = false;
    public bool ifTwoPlayer = true;

    private bool justShifted = false;

    private SpriteRenderer mySpriteRenderer;

    public Camera mainCamera;

    [SerializeField] private float lerpSpeed;

    private float elapsedTime = 0;

    public CapsuleCollider2D cucumberCol;

    public GameObject followCamera;



    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
        Debug.Log(this.gameObject.name + ": " + movement);

    } 

    public void OnUse(InputAction.CallbackContext context)
    {
        used = context.action.triggered;
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

    void Awake()
    {
        used = false;
        shift = false;

        mySpriteRenderer = GetComponent<SpriteRenderer>();

        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        if(ifTwoPlayer == false){
        mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        mainCamera.transform.parent = this.transform;
        }
        
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
            cucumberCol = GetComponent<CapsuleCollider2D>();
        }

        if(ifTwoPlayer == true)
        {
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            followCamera = Instantiate(followCamera,this.transform);
            if(this.gameObject.name != "Tomato(Clone)"){
                followCamera.GetComponent<Camera>().rect = new Rect(0.5f,0,0.5f,1);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //input
       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.magnitude);
       
       if(transform.Find("Main Camera") == null && ifTwoPlayer == false){
            mainCamera.transform.parent = null;
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime/lerpSpeed;

            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(transform.position.x, transform.position.y, -10), percentageComplete);
            if(mainCamera.transform.position == new Vector3(transform.position.x, transform.position.y, -10)){
                mainCamera.transform.parent = this.transform;
                elapsedTime = 0;
            }
       }

        if(shift == false)
        {
            justShifted = false;
        }
        if(this.gameObject.name == "Tomato(Clone)"){
            if(movement.x < 0 && mySpriteRenderer.flipX == false){
                if(mySpriteRenderer!= null){
                    mySpriteRenderer.flipX = true;
                }
            }
            if(movement.x > 0){
                mySpriteRenderer.flipX = false;
            }
            if(movement.y > 0){
                if(movement.x > 0){
                    mySpriteRenderer.flipX = true;
                }
                else if(movement.x < 0){
                    mySpriteRenderer.flipX = false;
                }
            }        
        }
        else{
            if(movement.x != 0 && movement.y == 0){
                cucumberCol.direction = CapsuleDirection2D.Vertical;
                cucumberCol.size = new Vector2(1.54f,6f);
                cucumberCol.offset = new Vector2(-0.04f, -1.5f);
            }
            else{
                cucumberCol.direction = CapsuleDirection2D.Horizontal;
                cucumberCol.size = new Vector2(8.53f, 1.54f);
                cucumberCol.offset = new Vector2(-0.16f, -0.04f);
            }
        }
    }



    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
