using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_script2 : MonoBehaviour
{
    public GameObject green_light;


    private void Update()
    {
        if (ATM_1.is_light2)
        {
            green_light.SetActive(true);
            Destroy(gameObject);
        }
    }
}
