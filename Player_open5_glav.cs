using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_open5_glav : MonoBehaviour
{
    public GameObject close_eyes;
    public GameObject vrag_pregrad;
    public GameObject loading;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "gold_door" && get_GOLD_key.is_grab_key)
        {
            get_GOLD_key.GO = true;
            Destroy(get_GOLD_key.KEY);
            Destroy(vrag_pregrad);
        }
        if (hit.gameObject.name == "brick"&&get_AXE.is_grab_axe)
        {
            VRLookWalk.IS_scrimer = true;
            close_eyes.SetActive(true);
            Destroy(hit.gameObject);
            Invoke("Destroy_brick", 2f);
        }
        if (hit.gameObject.name == "trigger_new_scene")
        {
            loading.SetActive(true);
            SceneManager.LoadScene("6_glav");
        }
    }
    void Destroy_brick()
    {
        VRLookWalk.IS_scrimer = false;
        close_eyes.SetActive(false);
    }
}
