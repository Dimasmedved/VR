using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATM_1 : MonoBehaviour
{
    MeshRenderer mesh;
    public Texture open;
    public static bool is_podhod = false;
    public static bool is_light = false;
    public static bool is_light2 = false;

    public AudioSource button_down;


    public GameObject ATM_light;
    public GameObject ATM_light1;
    public GameObject ATM_light_green;
    public GameObject ATM_light1_green;
    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    public void Open()
    {
        if (is_podhod)
        {
            mesh.material.SetTexture("_MainTex", open);
            is_light = true;
            button_down.Play();
            is_podhod = false;
            ATM_light.SetActive(false);
            ATM_light_green.SetActive(true);
        }
    }
    public void OPEN2()
    {
        if (is_podhod)
        {
            mesh.material.SetTexture("_MainTex", open);
            is_light2 = true;
            button_down.Play();
            ATM_light1.SetActive(false);
            ATM_light1_green.SetActive(true);
        }
    }
}
