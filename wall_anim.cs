using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_anim : MonoBehaviour
{
    public Animator anim;
    public static bool go;
    public GameObject ATM;

    private void Update()
    {
        if (go)
        {
            Destroy(ATM);
            anim.SetBool("GO", true);
        }
    }

}
