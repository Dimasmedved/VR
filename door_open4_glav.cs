using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open4_glav : MonoBehaviour
{
    public Animator anim;
    public static bool GO=false;
    void Update()
    {
        if (GO)
        {
            anim.SetBool("go", true); 
        }
    }

    
}
