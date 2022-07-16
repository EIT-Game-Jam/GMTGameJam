using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseStuff : MonoBehaviour
{

    public GameObject UI;
    public bool readyToBeUsed = false;

    // Start is called before the first frame update
    void Start()
    {
        readyToBeUsed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D()
    {
        UI.SetActive(true);
        readyToBeUsed = true;
    }

    void OnTriggerExit2D()
    {
        UI.SetActive(false);
        readyToBeUsed = false;
    }
}
