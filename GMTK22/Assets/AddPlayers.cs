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

    void awake()
    {
        
        
    


    }
    // Start is called before the first frame update
    void Start()
    {
        cucumberInput = PlayerInput.Instantiate(cucumber, controlScheme: "Keyboard", pairWithDevice: Keyboard.current);
        tomatoInput = PlayerInput.Instantiate(tomato, controlScheme: "Keyboard2", pairWithDevice: Keyboard.current);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
