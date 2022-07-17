using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twoplate : MonoBehaviour
{

    public GameObject otherPlate;
    public GameObject activator;
    public GameObject activato2;
    public Sprite pressedSprite;
    public Sprite  notPressedSprite;

    public bool isPressed;


    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        GetComponent<SpriteRenderer>().sprite = notPressedSprite;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if(isPressed == true && otherPlate.GetComponent<Twoplate>().isPressed == true)
        {
            activator.GetComponent<SpriteRenderer>().enabled = false;
            activator.GetComponent<BoxCollider2D>().enabled = false;
            activato2.GetComponent<SpriteRenderer>().enabled = false;
            activato2.GetComponent<BoxCollider2D>().enabled = false;
        }


        
    }



        void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            isPressed = true;
            GetComponent<SpriteRenderer>().sprite = pressedSprite;
        }
    }

        void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            isPressed = false;
            GetComponent<SpriteRenderer>().sprite = notPressedSprite;
        }
    }

}
