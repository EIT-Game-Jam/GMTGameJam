using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{

    public GameObject chopper;
    private bool isOn = false;

    public Sprite onSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn == true)
        {
            GetComponent<SpriteRenderer>().sprite = onSprite;
            chopper.GetComponent<Chopper>().TurnOn();
        }
    }

    public void Use(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            isOn = true;
        }
    }

}
