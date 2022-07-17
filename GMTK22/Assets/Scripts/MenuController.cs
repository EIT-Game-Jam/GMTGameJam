using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
<<<<<<< HEAD
=======
using UnityEngine.SceneManagement;
>>>>>>> origin/Malthe
>>>>>>> main
=======
=======
using UnityEngine.SceneManagement;
>>>>>>> origin/Malthe
>>>>>>> main

public class MenuController : MonoBehaviour
{
    public GameObject settingMenu;
    public GameObject tutorial;
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
    public GameObject credit;

=======
>>>>>>> main
=======
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
<<<<<<< HEAD
=======
>>>>>>> origin/Malthe
>>>>>>> main
=======
>>>>>>> origin/Malthe
>>>>>>> main

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        settingMenu.SetActive(false);
        PlayerPrefs.SetInt("TwoPlayer",0);

=======
<<<<<<< HEAD
=======
>>>>>>> main
        
=======
        settingMenu.SetActive(false);
        PlayerPrefs.SetInt("TwoPlayer",0);

>>>>>>> origin/Malthe
<<<<<<< HEAD
>>>>>>> main
=======
>>>>>>> main
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        
=======
<<<<<<< HEAD
=======
>>>>>>> main

=======
        
>>>>>>> origin/Malthe
<<<<<<< HEAD
>>>>>>> main
=======
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
        credit.SetActive(true);
    }   
=======
>>>>>>> main
=======
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
<<<<<<< HEAD
           SceneManager.LoadScene("Level1",LoadSceneMode.Single);
=======
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1,LoadSceneMode.Single);
>>>>>>> main
=======
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1,LoadSceneMode.Single);
>>>>>>> main
        }
        
    }

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> origin/Malthe
>>>>>>> main
=======
>>>>>>> origin/Malthe
>>>>>>> main
}
