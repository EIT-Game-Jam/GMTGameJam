using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AddPlayers : MonoBehaviour
{

    public GameObject cucumber;
    public Transform cucumberSpawn;
    public GameObject tomato;
    public Transform tomatoSpawn;

    public PlayerInput cucumberInput;
    public PlayerInput tomatoInput;

<<<<<<< HEAD
    public GameObject divider;


=======
<<<<<<< HEAD
    public bool ifTwoPlayer = true;
=======
    public GameObject divider;


>>>>>>> origin/Malthe
>>>>>>> main

    void awake()
    {
        
        
    


    }
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("TwoPlayer") == 0){
            cucumberInput = PlayerInput.Instantiate(cucumber, controlScheme: "Keyboard", pairWithDevice: Keyboard.current);
            tomatoInput = PlayerInput.Instantiate(tomato, controlScheme: "Keyboard2", pairWithDevice: Keyboard.current);
            cucumberInput.transform.position = cucumberSpawn.position;
            tomatoInput.transform.position = tomatoSpawn.position;
<<<<<<< HEAD
            divider.SetActive(false);
=======
<<<<<<< HEAD
=======
            divider.SetActive(false);
>>>>>>> origin/Malthe
>>>>>>> main
    }

        if(PlayerPrefs.GetInt("TwoPlayer") == 1){
            cucumberInput = PlayerInput.Instantiate(cucumber, controlScheme: "Keyboard", pairWithDevice: Keyboard.current);
            tomatoInput = PlayerInput.Instantiate(tomato, controlScheme: "Arrow", pairWithDevice: Keyboard.current);
            cucumberInput.transform.position = cucumberSpawn.position;
            tomatoInput.transform.position = tomatoSpawn.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
