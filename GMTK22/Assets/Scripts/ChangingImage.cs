using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingImage : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public Sprite oldSprite;
    public bool isOn = true;
    public AudioSource switchAudio;

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
        isOn = true;
        original.sprite = newSprite;
    }

    public void OldImage()
    {
        isOn = false;
        original.sprite = oldSprite;
    }

    public void PlaySound()
    {
        if(isOn == false)
        {
            switchAudio.Play();
        }
        
    }

}
