using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{

    [SerializeField] private GameObject otherPipe;

    private bool lerping = false;
    public float lerpSpeed;
    private float elapsedTime;
    private GameObject player;

<<<<<<< HEAD
    public bool isClosed;

    [SerializeField] private Sprite openSprite;
    [SerializeField] private Sprite closedSprite;

    // Start is called before the first frame update
    void Start()
    {

=======
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> main
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD

        if (isClosed == true)
        {
            GetComponent<SpriteRenderer>().sprite = closedSprite;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = openSprite;
        }

        if (lerping == true)
        {
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime / lerpSpeed;

            if (transform.rotation == Quaternion.Euler(Vector3.zero))
            {
                player.transform.position = Vector3.Lerp(player.transform.position, otherPipe.transform.position - new Vector3(0, 1.5f, 0), percentageComplete);

                if (player.transform.position == otherPipe.transform.position - new Vector3(0, 1.5f, 0))
                {
                    lerping = false;
                    elapsedTime = 0f;
                    player.GetComponent<SpriteRenderer>().enabled = true;
                }

            }
            else
            {
                player.transform.position = Vector3.Lerp(player.transform.position, otherPipe.transform.position - new Vector3(2, 0, 0), percentageComplete);

                if (player.transform.position == otherPipe.transform.position - new Vector3(2, 0, 0))
                {
                    lerping = false;
                    elapsedTime = 0f;
                    player.GetComponent<SpriteRenderer>().enabled = true;
                }
            }


        }


        if (otherPipe.GetComponent<UseStuff>().once == true)
=======
        if(lerping == true)
        {
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime/lerpSpeed;
            player.transform.position = Vector3.Lerp(player.transform.position , otherPipe.transform.position - new Vector3(0,1,0), percentageComplete);
        
            if(player.transform.position == otherPipe.transform.position- new Vector3(0,1,0))
            {
                lerping = false;
                elapsedTime = 0f;
                player.GetComponent<SpriteRenderer>().enabled = true;
            }
        
        }
        

        if(otherPipe.GetComponent<UseStuff>().once == true)
>>>>>>> main
        {
            GetComponent<UseStuff>().once = true;
        }

    }

    public void Use(Collider2D col)
    {

<<<<<<< HEAD
        if (col.gameObject.GetComponent<SpriteRenderer>() != null && col.gameObject.tag == "Player" && isClosed == false)
=======
        if(col.gameObject.GetComponent<SpriteRenderer>() != null && col.gameObject.tag == "Player")
>>>>>>> main
        {
            player = col.gameObject;
            player.GetComponent<SpriteRenderer>().enabled = false;
            lerping = true;
<<<<<<< HEAD

=======
            
>>>>>>> main

        }

    }



}
