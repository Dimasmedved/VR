using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pogrom_anim : MonoBehaviour
{
    public Animator anim;
    public static bool pog=false;
    void Update()
    {
        if (pog)
        {
            anim.SetBool("prihod",true);
            Destroy(gameObject,15f);
        }
    }
    
    
}
