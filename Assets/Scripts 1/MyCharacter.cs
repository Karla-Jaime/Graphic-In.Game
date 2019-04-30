using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    public float colorPower= 1f;

    private void Start()
    {
        render = GetComponent<Renderer>();
               
    }

    private void update()
    {
        render.material.SetFloat("_ColorPower", colorPower);
    }
}
