using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_open_glav4 : MonoBehaviour
{
    public GameObject Scrimer;
    public GameObject BlackMEN;

    public GameObject vrag_pregrad;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "door1"&&door_open4_glav.GO==false)
        {
            BlackMEN.SetActive(true);
            Invoke("Destroymen", 5f);
        }
        if (hit.gameObject.name == "trigger_waghet")
        {
            VRLookWalk.IS_scrimer = true;
            pogrom_anim.pog = true;
            Destroy(hit.gameObject);
            Invoke("NOscrimer", 15f);

        }
        if (hit.gameObject.name == "camera_door"&&get_key_camera.is_grab_key)
        {
            open_camera_door.is_open = true;
        }
        if (hit.gameObject.name == "left_door" && get_key_left_door.is_grab_key)
        {
            left_door_open.is_openn = true;
        }
        if(hit.gameObject.name=="scrimer_key"&& get_key_camera.is_grab_key)
        {
            Destroy(hit.gameObject);
            Scrimer.SetActive(true);
            Invoke("NOscrimer", 2f);
        }
        if (hit.gameObject.name == "gold_door" && get_GOLD_key.is_grab_key)
        {
            get_GOLD_key.GO = true;
            Destroy(get_GOLD_key.KEY);
            Destroy(vrag_pregrad);
        }
    }
    void NOscrimer()
    {
        Scrimer.SetActive(false);
        VRLookWalk.IS_scrimer = false;
    }
    void Destroymen()
    {
        door_open4_glav.GO = true;
        Destroy(BlackMEN);
    }
}
