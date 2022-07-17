using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
<<<<<<< HEAD
=======
using UnityEngine.SceneManagement;
>>>>>>> origin/Malthe
>>>>>>> main

public class MenuController : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject tutorial;
<<<<<<< HEAD
=======
<<<<<<< HEAD
    public GameObject credit;

=======
>>>>>>> main
    public GameObject creditsMenu;

    public Animator playAnim;

    void awake()
    {
        settingMenu.SetActive(true);
        
    }
<<<<<<< HEAD
=======
>>>>>>> origin/Malthe
>>>>>>> main

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        settingMenu.SetActive(false);
        PlayerPrefs.SetInt("TwoPlayer",0);

=======
<<<<<<< HEAD
        
=======
        settingMenu.SetActive(false);
        PlayerPrefs.SetInt("TwoPlayer",0);

>>>>>>> origin/Malthe
>>>>>>> main
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        
=======
<<<<<<< HEAD

=======
        
>>>>>>> origin/Malthe
>>>>>>> main
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
=======
<<<<<<< HEAD
        credit.SetActive(true);
    }   
=======
>>>>>>> main
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
<<<<<<< HEAD
           SceneManager.LoadScene("Level1",LoadSceneMode.Single);
=======
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1,LoadSceneMode.Single);
>>>>>>> main
        }
        
    }

<<<<<<< HEAD
=======
>>>>>>> origin/Malthe
>>>>>>> main
}
