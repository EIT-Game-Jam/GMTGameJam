using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour
{

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            if(col.gameObject.GetComponent<PlayerMovement>().diceNum == 3)
            {
                wall.GetComponent<BoxCollider2D>().enabled = false;
            }

        }
    }
}