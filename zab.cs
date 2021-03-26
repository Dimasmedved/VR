using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zab : MonoBehaviour
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
