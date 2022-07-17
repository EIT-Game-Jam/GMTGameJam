using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plate : MonoBehaviour
{

    public GameObject activator;
    public Sprite pressedSprite;
    public Sprite  notPressedSprite;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = notPressedSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            activator.GetComponent<Pipe>().isClosed = false;
            GetComponent<SpriteRenderer>().sprite = pressedSprite;
        }
    }

        void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            
            GetComponent<SpriteRenderer>().sprite = notPressedSprite;
        }
    }

}
