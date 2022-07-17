using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paint : MonoBehaviour
{
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
                col.gameObject.GetComponent<PlayerMovement>().diceNum = 4;
            }

        }
    }

}
