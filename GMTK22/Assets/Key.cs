using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Use(Collider2D col)
    {
<<<<<<< HEAD
        
=======
        Debug.Log(col);
>>>>>>> main

        if(col.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            transform.parent = col.transform;
<<<<<<< HEAD
            GetComponent<UseStuff>().enabled = false;   
=======
>>>>>>> main

        }


    }
}
