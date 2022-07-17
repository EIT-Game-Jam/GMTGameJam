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

    public bool ifTwoPlayer = true;

    void awake()
    {
        
        
    


    }
    // Start is called before the first frame update
    void Start()
    {
        if(ifTwoPlayer == false){
            cucumberInput = PlayerInput.Instantiate(cucumber, controlScheme: "Keyboard", pairWithDevice: Keyboard.current);
            tomatoInput = PlayerInput.Instantiate(tomato, controlScheme: "Keyboard2", pairWithDevice: Keyboard.current);
            cucumberInput.transform.position = cucumberSpawn.position;
            tomatoInput.transform.position = tomatoSpawn.position;
    }

        if(ifTwoPlayer == true){
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
