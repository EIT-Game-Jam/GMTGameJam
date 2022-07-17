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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lerping == true)
        {
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime/lerpSpeed;
            player.transform.position = Vector3.Lerp(player.transform.position , otherPipe.transform.position, percentageComplete);
        
            if(player.transform.position == otherPipe.transform.position)
            {
                lerping = false;
                elapsedTime = 0f;
                player.GetComponent<SpriteRenderer>().enabled = true;
            }
        
        }
        
    }

    public void Use(Collider2D col)
    {
        if(col.gameObject.GetComponent<SpriteRenderer>() != null && col.gameObject.tag == "Player")
        {
            player = col.gameObject;
            player.GetComponent<SpriteRenderer>().enabled = false;
            lerping = true;
            

        }

    }



}
