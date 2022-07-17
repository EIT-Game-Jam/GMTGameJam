using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player" && coll.gameObject.name == "Cucumber(Clone)")
        {
            if(coll.gameObject.GetComponent<PlayerMovement>().diceNum < 3)
            {
                GetComponent<BoxCollider2D>().isTrigger = true;
            }
            
        }
        else
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
    }


}
