using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseStuff : MonoBehaviour
{

    public GameObject UI;
    public bool readyToBeUsed = false;

    Collider2D colli;

    public bool once = false;

    // Start is called before the first frame update
    void Start()
    {
        readyToBeUsed = false;
        once = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (colli != null)
        {
            if (this.gameObject.tag == "Pipe" && readyToBeUsed == true && colli.gameObject.name == "Tomato(Clone)" && colli.gameObject.GetComponent<PlayerMovement>().used == true)
            {
                readyToBeUsed = false;
                GetComponent<Pipe>().Use(colli);
                once = true;
            }
            else if (this.gameObject.tag == "Key" && readyToBeUsed == true && colli.gameObject.GetComponent<PlayerMovement>().used == true)
            {
                once = true;
                GetComponent<Key>().Use(colli);
                readyToBeUsed = false;
            }

            else if (this.gameObject.tag == "Chopper" && readyToBeUsed == true && colli.gameObject.GetComponent<PlayerMovement>().used == true)
            {
                once = true;
                GetComponent<Chopper>().isOn = !GetComponent<Chopper>().isOn;

            }

            else if (this.gameObject.tag == "Lift" && readyToBeUsed == true && colli.gameObject.GetComponent<PlayerMovement>().used == true)
            {
                once = true;
                GetComponent<lift>().isOn = !GetComponent<lift>().isOn;
                GetComponent<lift>().Use(colli);
                readyToBeUsed = false;

            }

            else if (this.gameObject.tag == "Power" && readyToBeUsed == true && colli.gameObject.GetComponent<PlayerMovement>().used == true)
            {
                once = true;

                GetComponent<power>().Use(colli);
                readyToBeUsed = false;

            }



        }

        else
        {
            once = false;

        }

    }



    void OnTriggerEnter2D(Collider2D col)
    {


        UI.SetActive(true);

        readyToBeUsed = true;
        colli = col;

        if (this.gameObject.tag == "Chopper")
        {
            GetComponent<Chopper>().Use(col);
        }


    }


    void OnTriggerStay2D(Collider2D col)
    {

        UI.SetActive(true);

        readyToBeUsed = true;
        colli = col;

        if (this.gameObject.tag == "Chopper")
        {
            GetComponent<Chopper>().Use(col);
        }


    }




    void OnTriggerExit2D(Collider2D col)
    {

        if (colli.gameObject.tag == "Player")
        {
            if (colli.gameObject.GetComponent<PlayerMovement>().used == false)
            {
                once = false;
            }
        }

        UI.SetActive(false);


        if (this.gameObject.tag != "Key")
        {
            UI.SetActive(false);
        }

        readyToBeUsed = false;
        colli = null;

    }
}
