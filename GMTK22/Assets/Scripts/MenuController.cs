using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject tutorial;
    public GameObject creditsMenu;

    public Animator playAnim;

    void awake()
    {
        settingMenu.SetActive(true);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        settingMenu.SetActive(false);
        PlayerPrefs.SetInt("TwoPlayer",0);

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
        creditsMenu.SetActive(true);
    }   


    public void TwoPlayer(bool ifTwoPlayer)
    {
        if(ifTwoPlayer == true)
        {
            PlayerPrefs.SetInt("TwoPlayer",1);
        }
        else
        {
            PlayerPrefs.SetInt("TwoPlayer",0);
        }
        
    }

    public void Play()
    {
         if (playAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !playAnim.IsInTransition(0))
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1,LoadSceneMode.Single);
        }
        
    }

}
