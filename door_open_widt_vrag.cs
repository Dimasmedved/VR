using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open_widt_vrag : MonoBehaviour
{
    public Animator anim;
    void Update()
    {
         if (kaseta.Is_muz)
         {
             anim.SetBool("open", true);
         }
    }
}
