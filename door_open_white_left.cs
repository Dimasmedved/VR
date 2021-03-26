using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open_white_left : MonoBehaviour
{
    public Animator anim;
    
    void Update()
    {
       if(Player_open.a == 1)
        {
            anim.SetBool("go", true);
        }
       
    }
}
