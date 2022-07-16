using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingImage : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public Sprite oldSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewImage()
    {
        original.sprite = newSprite;
    }

    public void OldImage()
    {
        original.sprite = oldSprite;
    }
}
