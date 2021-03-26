using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vrag_uxod : MonoBehaviour
{
    public Animator anim;
    public static bool ok;
    private void Update()
    {
        if (ok)
        {
            anim.SetBool("uxod", true);
            Destroy(gameObject, 1.7f);
        }
    }
}
