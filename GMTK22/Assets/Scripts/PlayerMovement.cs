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
<<<<<<< HEAD
=======
<<<<<<< HEAD
    public bool ifTwoPlayer = true;
>>>>>>> main

    public bool isPaused = false;
=======
>>>>>>> origin/Malthe

    private bool justShifted = false;

    private SpriteRenderer mySpriteRenderer;

    public Camera mainCamera;

    [SerializeField] private float lerpSpeed;

    private float elapsedTime = 0;

    public CapsuleCollider2D cucumberCol;

    public GameObject followCamera;

<<<<<<< HEAD
    public int diceNum = 0;

=======
<<<<<<< HEAD
    private bool once;
>>>>>>> main


    public void Paused(InputAction.CallbackContext context)
    {
        isPaused = context.action.triggered;
    }

=======
    public int diceNum = 0;


>>>>>>> origin/Malthe

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
<<<<<<< HEAD


    }
=======
<<<<<<< HEAD
        Debug.Log(this.gameObject.name + ": " + movement);

    }
=======
        

    } 
>>>>>>> origin/Malthe
>>>>>>> main

    public void OnUse(InputAction.CallbackContext context)
    {
        used = context.action.triggered;
    }

    public void OnShift(InputAction.CallbackContext context)
    {
<<<<<<< HEAD
        if (PlayerPrefs.GetInt("TwoPlayer") == 0)
=======
<<<<<<< HEAD
        if (PlayerPrefs.GetInt("TwoPlayer") == 0)
        {
            shift = context.action.triggered;
            if (shift == true && justShifted == false)
            {

                Debug.Log(this.gameObject.name + ": " + shift);
                otherPlayer.GetComponent<PlayerMovement>().enabled = true;

                GetComponent<PlayerMovement>().enabled = false;


            }
=======
        if(PlayerPrefs.GetInt("TwoPlayer") == 0)
>>>>>>> main
        {
            shift = context.action.triggered;
            if (shift == true && justShifted == false)
            {

<<<<<<< HEAD
                Debug.Log(this.gameObject.name + ": " + shift);
                otherPlayer.GetComponent<PlayerMovement>().enabled = true;

                GetComponent<PlayerMovement>().enabled = false;


            }
=======
            Debug.Log(this.gameObject.name + ": " + shift);
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            
            GetComponent<PlayerMovement>().enabled = false;
            
            
        }
>>>>>>> origin/Malthe
>>>>>>> main
        }
    }


    public void OnEnable()
    {
        justShifted = true;


    }


    public void TwoPlayer(InputAction.CallbackContext context)
    {
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
      
>>>>>>> origin/Malthe
>>>>>>> main
    }

    void Awake()
    {
        used = false;
        shift = false;
        diceNum = 0;

        mySpriteRenderer = GetComponent<SpriteRenderer>();

        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> main
        if (PlayerPrefs.GetInt("TwoPlayer") == 0)
        {
            mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
            mainCamera.transform.parent = this.transform;
<<<<<<< HEAD
        }



=======
        }
        once = false;
=======
        if(PlayerPrefs.GetInt("TwoPlayer") == 0){
        mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        mainCamera.transform.parent = this.transform;
        }
        
>>>>>>> origin/Malthe
>>>>>>> main
    }

    void Start()
    {

<<<<<<< HEAD

        if (this.gameObject.name == "Tomato(Clone)")
=======
<<<<<<< HEAD

        if (this.gameObject.name == "Tomato(Clone)")
=======
        
        if(this.gameObject.name == "Tomato(Clone)")
>>>>>>> origin/Malthe
>>>>>>> main
        {
            otherPlayer = GameObject.Find("Cucumber(Clone)");
        }
        else
        {
            otherPlayer = GameObject.Find("Tomato(Clone)");
            cucumberCol = GetComponent<CapsuleCollider2D>();
        }

<<<<<<< HEAD
        if (this.gameObject.name != "Tomato(Clone)")
        {
            this.enabled = false;
            diceNum = 0;

        }

        if (PlayerPrefs.GetInt("TwoPlayer") == 1)
        {
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            followCamera = Instantiate(followCamera, this.transform);
            if (this.gameObject.name != "Tomato(Clone)")
            {
                followCamera.GetComponent<Camera>().rect = new Rect(0.5f, 0, 0.5f, 1);
=======
<<<<<<< HEAD
        if (PlayerPrefs.GetInt("TwoPlayer") == 1)
        {
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            followCamera = Instantiate(followCamera, this.transform);
            if (this.gameObject.name != "Tomato(Clone)")
            {
                followCamera.GetComponent<Camera>().rect = new Rect(0.5f, 0, 0.5f, 1);
=======
        if(PlayerPrefs.GetInt("TwoPlayer") == 1)
        {
            otherPlayer.GetComponent<PlayerMovement>().enabled = true;
            followCamera = Instantiate(followCamera,this.transform);
            if(this.gameObject.name != "Tomato(Clone)"){
                followCamera.GetComponent<Camera>().rect = new Rect(0.5f,0,0.5f,1);
>>>>>>> origin/Malthe
>>>>>>> main
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //input
<<<<<<< HEAD
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);
        animator.SetInteger("ChoppedUp",diceNum);

        if (transform.Find("Main Camera") == null && PlayerPrefs.GetInt("TwoPlayer") == 0)
        {
=======
<<<<<<< HEAD
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.magnitude);

        if (transform.Find("Main Camera") == null && PlayerPrefs.GetInt("TwoPlayer") == 0)
        {
            mainCamera.transform.parent = null;
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime / lerpSpeed;

            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(transform.position.x, transform.position.y, -10), percentageComplete);
            if (mainCamera.transform.position == new Vector3(transform.position.x, transform.position.y, -10))
            {
                mainCamera.transform.parent = this.transform;
                elapsedTime = 0;
            }
        }

        if (shift == false)
        {
            justShifted = false;
        }
        if (this.gameObject.name == "Tomato(Clone)")
        {
            if (movement.x < 0 && mySpriteRenderer.flipX == false)
            {
                if (mySpriteRenderer != null)
                {
                    mySpriteRenderer.flipX = true;
                }
            }
            if (movement.x > 0)
            {
                mySpriteRenderer.flipX = false;
            }
            if (movement.y > 0)
            {
                if (movement.x > 0)
                {
                    mySpriteRenderer.flipX = true;
                }
                else if (movement.x < 0)
                {
                    mySpriteRenderer.flipX = false;
                }
            }
        }
        else
        {
            if (movement.x != 0 && movement.y == 0)
            {
                cucumberCol.direction = CapsuleDirection2D.Vertical;
                cucumberCol.size = new Vector2(1.54f, 6f);
                cucumberCol.offset = new Vector2(-0.04f, -1.5f);
            }
            else
            {
=======
       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.magnitude);
       
       if(transform.Find("Main Camera") == null && PlayerPrefs.GetInt("TwoPlayer") == 0){
>>>>>>> main
            mainCamera.transform.parent = null;
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime / lerpSpeed;

            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(transform.position.x, transform.position.y, -10), percentageComplete);
            if (mainCamera.transform.position == new Vector3(transform.position.x, transform.position.y, -10))
            {
                mainCamera.transform.parent = this.transform;
                elapsedTime = 0;
            }
        }

        if (shift == false)
        {
            justShifted = false;
        }
        if (this.gameObject.name == "Tomato(Clone)")
        {
            if (movement.x < 0 && mySpriteRenderer.flipX == false)
            {
                if (mySpriteRenderer != null)
                {
                    mySpriteRenderer.flipX = true;
                }
            }
            if (movement.x > 0)
            {
                mySpriteRenderer.flipX = false;
            }
            if (movement.y > 0)
            {
                if (movement.x > 0)
                {
                    mySpriteRenderer.flipX = true;
                }
                else if (movement.x < 0)
                {
                    mySpriteRenderer.flipX = false;
                }
            }
        }
        else
        {
            if (movement.x != 0 && movement.y == 0)
            {
                cucumberCol.direction = CapsuleDirection2D.Vertical;
                cucumberCol.size = new Vector2(1.54f, 6f);
                cucumberCol.offset = new Vector2(-0.04f, -1.5f);
            }
<<<<<<< HEAD
            else
            {
=======
            else{
>>>>>>> origin/Malthe
>>>>>>> main
                cucumberCol.direction = CapsuleDirection2D.Horizontal;
                cucumberCol.size = new Vector2(8.53f, 1.54f);
                cucumberCol.offset = new Vector2(-0.16f, -0.04f);
            }
        }
<<<<<<< HEAD

        if (isPaused == true && once == false)
        {
            GameObject.Find("CanvasPauseMenu").GetComponent<PauseMenu>().TurnOnPauseMenu(isPaused);
            once = true;
            Debug.Log("nu");
        }
        else if (isPaused == false)
        {
            once = false;
        }

=======
>>>>>>> origin/Malthe
    }



    void FixedUpdate()
    {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
