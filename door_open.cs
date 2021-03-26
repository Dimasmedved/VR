using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_open : MonoBehaviour
{
    public static bool is_grabing_key = false;
    public GameObject key;
    public Animator anim;
    public static bool open = false;

    public static GameObject KEY;
    //рука
    public Transform hand;

    //audio
    public AudioSource get_key;
    private void Start()
    {
        anim.GetComponent<Animator>();
    }
    public void getKey()
    {
        
        is_grabing_key = true;
        KEY = Instantiate(key, hand.transform.position, hand.transform.rotation);
        KEY.transform.parent = hand.transform;
        Destroy(key);
        get_key.Play();
    }
    private void Update()
    {
        if (is_grabing_key)
        {
            if (open)
            {
                anim.SetBool("is_key", true);
            }
        }
    }
}
