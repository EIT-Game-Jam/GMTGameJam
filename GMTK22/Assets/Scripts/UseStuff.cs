using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseStuff : MonoBehaviour
{

    public GameObject UI;
    public bool readyToBeUsed = false;

    Collider2D colli;

    // Start is called before the first frame update
    void Start()
    {
        readyToBeUsed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.tag == "Pipe" && readyToBeUsed == true && colli != null)
        {
            GetComponent<Pipe>().Use(colli);
        }
        
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        UI.SetActive(true);
        readyToBeUsed = true;
        colli = col;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        UI.SetActive(false);
        readyToBeUsed = false;
        colli = null;
    }
}
