using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject tutorial;
    public GameObject credit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void settingsMenu()
    {
        settingMenu.SetActive(true);

    }

    public void tutorialMenu()
    {
        tutorial.SetActive(true);
    }

    public void creditMenu()
    {
        credit.SetActive(true);
    }   
}
