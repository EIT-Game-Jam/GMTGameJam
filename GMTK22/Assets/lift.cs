using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lift : MonoBehaviour
{

    public GameObject Lock;
    public bool isOn;

    private bool isLocked;

    public Transform[] positions;

    private GameObject player;

    public float lerpSpeed = 5f;
    private float elapsedTime;
    private int positionNum;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        isLocked = false;
        positionNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(isOn == true)
        {
            player.transform.parent = this.transform;
            player.GetComponent<Collider2D>().enabled = false;
            elapsedTime += Time.deltaTime;
            var percentageComplete = elapsedTime/lerpSpeed;

            transform.position = Vector3.Lerp(transform.position,positions[positionNum].position,percentageComplete);


        }

        if(transform.position == positions[positionNum].position && isOn == true)
        {
            player.GetComponent<Collider2D>().enabled = true;
            isOn = false;
            elapsedTime = 0;
            player.transform.parent = null;
            if(positionNum == 0)
            {
                positionNum = 1;
            }
            else{
                positionNum = 0;
            }
        }

    }


    public void Use(Collider2D col)
    {

        if(col.gameObject.tag == "Player" && col.transform.Find("key") == true)
        {
            Destroy(col.transform.Find("key").gameObject);
            Destroy(Lock);
            isLocked = false;
        }

        if(isLocked == false)
        {
          isOn = true;  
        }
        if(col.gameObject.tag == "Player")
        {
            player = col.gameObject;
        }

    }

}
