using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_box : MonoBehaviour
{
    public Animator anim;
    public static bool go;
    void Update()
    {
        if (go)
        {
            anim.SetBool("go", true);
        }
    }
}
