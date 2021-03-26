using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_GOLD_key : MonoBehaviour
{
    public GameObject hand;

    public static GameObject KEY;
    public static bool is_grab_key;
    public void Get_key()
    {
        if (is_grab_key==false)
        {
            KEY = Instantiate(gameObject, hand.transform.position, hand.transform.rotation);
            KEY.transform.parent = hand.transform;
            Destroy(gameObject);
            is_grab_key = true;
        }
    }
    //door

    public Animator anim;
    public static bool GO = false;
    void Update()
    {
        if (GO)
        {
            anim.SetBool("gold", true);
        }
    }
}
