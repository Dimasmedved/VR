using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_camera_door : MonoBehaviour
{
    public Animator anim;
    public static bool is_open=false;
    void Update()
    {
        if (is_open)
        {
            anim.SetBool("key",true);
            Destroy(get_key_camera.KEY);
        }
    }
}
