using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_script : MonoBehaviour
{
    public GameObject green_light;


    private void Update()
    {
        if (ATM_1.is_light)
        {
            green_light.SetActive(true);
            Destroy(gameObject);
        }
    }
}
