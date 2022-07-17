using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
=======
using UnityEngine.SceneManagement;
>>>>>>> origin/Malthe

public class MenuController : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject tutorial;
<<<<<<< HEAD
    public GameObject credit;

=======
    public GameObject creditsMenu;

    public Animator playAnim;

    void awake()
    {
        settingMenu.SetActive(true);
        
    }
>>>>>>> origin/Malthe

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        
=======
        settingMenu.SetActive(false);
        PlayerPrefs.SetInt("TwoPlayer",0);

>>>>>>> origin/Malthe
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD

=======
        
>>>>>>> origin/Malthe
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
<<<<<<< HEAD
        credit.SetActive(true);
    }   
=======
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

>>>>>>> origin/Malthe
}
