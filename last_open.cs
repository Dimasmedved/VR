using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class last_open : MonoBehaviour
{
    public Animator anim;
    public static bool open;
    void Update()
    {
        if (open)
        {
            anim.SetBool("door", true);
        }
    }
}
