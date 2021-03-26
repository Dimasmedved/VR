using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bas_open : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
        if (Player_open_2_galv.IS_besament_open)
        {
            anim.SetBool("bas", true);
        }
    }
}
