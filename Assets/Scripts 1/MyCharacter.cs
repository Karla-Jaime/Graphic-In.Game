using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///////
using UnityEngine.UI;
//Se agrega una liberia para poder controlar UI

public class MyCharacter : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    public float colorPower= 1f;

    //Para mostrar una variable en el inspector de Unity
    [SerializeField]
    Slider sld_colorPower;

    private void Start()
    {
        render = GetComponent<Renderer>();
               
    }

    private void Update()
    {
        render.material.SetFloat("_ColorPower", sld_colorPower.value);
    }

}
