using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
   public static bool open_door=false;
    public Animator anim;
    private void Update()
    {
        if (open_door)
        {
            anim.SetBool("open", true);
            Destroy(Player_get_key.KEY);
        }
    }
}
