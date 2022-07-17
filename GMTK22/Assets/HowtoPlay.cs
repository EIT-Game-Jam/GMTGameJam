using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowtoPlay : MonoBehaviour
{
    public GameObject[] pages;
    public GameObject NextPage;
    public bool GoToNextPage;
    public int NextCounter;
    public GameObject PreviousPage;
    public bool GoToPreviousPage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Next()
    {
        NextPage.SetActive(true);
    }

    public void Previous()
    {
        PreviousPage.SetActive(true);
    }

    public void NextTrue(bool GoNext)
    {
        GoToNextPage = GoNext;
        if(GoToNextPage = true)
        {
            NextCounter++;
        }
    }

    public void PreviousTrue(bool GoBack)
    {
        GoToPreviousPage = GoBack;
        if(GoToPreviousPage = true)
        {
            NextCounter--;
        }
    }
}
