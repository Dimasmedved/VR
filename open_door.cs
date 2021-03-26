using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour
{
    public Animator anim;
    public static bool Open = false;
    void Update()
    {
        if (Open)
        { 
            anim.SetBool("Is_end", true);
            Destroy(Player_open.KEY);
        }
    }
}
