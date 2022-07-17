using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopper : MonoBehaviour
{

    public bool isOn = false;
    [SerializeField] private float chopNum;
    [SerializeField] private Sprite onSprite;
    [SerializeField] private Sprite offSprite;


    void Awake()
    {
        isOn = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }


    public void TurnOn()
    {
        isOn = true;
        GetComponent<SpriteRenderer>().sprite = onSprite;
        gameObject.GetComponent<Animator>().SetBool("isOn", true);
    }

      public void TurnOff()
    {
        isOn = true;
        GetComponent<SpriteRenderer>().sprite = offSprite;
        gameObject.GetComponent<Animator>().SetBool("isOn", false);
    }


    public void Use(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && isOn == true)
        {
            if(col.gameObject.GetComponent<PlayerMovement>().diceNum == chopNum)
            {
                col.gameObject.GetComponent<PlayerMovement>().diceNum++;
            }

        }
    }

}
