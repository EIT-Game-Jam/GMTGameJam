using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject otherSwitch;
    public bool isOn = false;
    public SpriteRenderer spriteRenderer;
    public Sprite onSprite;
    public Sprite offSprite;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn==true)
        {
            spriteRenderer.sprite = onSprite;
        }
        else 
        {
            spriteRenderer.sprite = offSprite;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.tag=="Player"){
            
        if(otherSwitch.transform.GetComponent<Switch>().isOn == true)
        {
            otherSwitch.transform.GetComponent<Switch>().isOn=false;
            isOn=true;
        }
        else 
        {
            isOn=true;
        }
        }
    }


}
