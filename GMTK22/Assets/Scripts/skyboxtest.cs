using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxtest : MonoBehaviour
{
    public Material night;

    public Material day;
    public Color color;
    public float expo;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        day.SetColor("_Tint",color);
        ChangeSkyBox(day, expo);
    }


    public void ChangeSkyBox(Material skyboxMat, float exposure)
    {
        RenderSettings.skybox=skyboxMat;
        RenderSettings.skybox.SetFloat("_Exposure", exposure);
    }
}
