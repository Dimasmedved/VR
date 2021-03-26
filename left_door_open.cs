using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class left_door_open : MonoBehaviour
{
    public GameObject loading;
    public Animator anim;
    public static bool is_openn = false;
    void Update()
    {
        if (is_openn)
        {
            anim.SetBool("key", true);
            Destroy(get_key_left_door.KEY);
            Invoke("New_glav", 1f);
        }
    }


    void New_glav()
    {
        VRLookWalk.IS_scrimer = false;
        loading.SetActive(true);
        SceneManager.LoadScene("5_glav");
    }
}
