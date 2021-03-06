using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsClose : MonoBehaviour
{
    public Animator creditsAnim;

    void Update()
    {
        if (creditsAnim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !creditsAnim.IsInTransition(0))
        {
            close();
        }


    }

    public void close()
    {
        this.gameObject.SetActive(false);
    }
}
