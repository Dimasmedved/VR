using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_open_2_galv : MonoBehaviour
{
    public static bool IS_besament_open = false;
    public GameObject vrag;
    public GameObject scrimer;


    public GameObject vrag_wall;


    //last
    public GameObject white_light;
    public GameObject vrag1;
    public GameObject vrag2;
    public GameObject red_light;

    public GameObject loading;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "GLAV_stair")
        {
            IS_besament_open = true;
            Destroy(vrag);
        }
        if (hit.gameObject.name == "trigger")
        {
            vrag_uxod.ok = true;
            Destroy(hit.gameObject);
        }
        if(hit.gameObject.name== "trigger_scrimer")
        {
            Destroy(hit.gameObject);
            scrimer.SetActive(true);
            VRLookWalk.IS_scrimer = true;
            Invoke("Scrimer_exit", 1f);
           
        }
        if (hit.gameObject.name == "ATM")
        {
            ATM_1.is_podhod = true;
        }
        if (hit.gameObject.name == "trigger_miniVrag")
        {
            mini_vrag_prihod.run = true;
            Destroy(hit.gameObject);
        }
        if (hit.gameObject.name == "trigger_dvig_wall")
        {
            Destroy(hit.gameObject);
            vrag_wall.SetActive(true);
            VRLookWalk.IS_scrimer = true;
            Invoke("wall_anim_vse", 5.5f);
        }
       if(hit.gameObject.name== "trigger_open_zav")
        {
            if (ATM_1.is_light == true && ATM_1.is_light2 == true) {
                Destroy(hit.gameObject);
                zab.go = true;
            }
        }
       if(hit.gameObject.name== "trigger_open_last_door")
        {
            Destroy(hit.gameObject);
            last_open.open = true;
        }
      if(hit.gameObject.name== "last_scrimer")
        {
            Destroy(hit.gameObject);
            VRLookWalk.IS_scrimer = true;
            Destroy(white_light);
            Invoke("prihod1", 2f);
        }
    }
    void wall_anim_vse()
    {
        VRLookWalk.IS_scrimer = false;
        wall_anim.go = true;
        Destroy(vrag_wall);
    }
    void Scrimer_exit()
    {
        scrimer.SetActive(false);
        VRLookWalk.IS_scrimer = false;
    }



    //last
    void prihod1()
    {
        vrag1.SetActive(true);
        Invoke("prihod2", 4f);
    }
    void prihod2()
    {
        vrag1.SetActive(false);
        vrag2.SetActive(true);
        Invoke("last_scrimer", 4f);
    }
    void last_scrimer()
    {
        vrag2.SetActive(false);
        scrimer.SetActive(true);
        red_light.SetActive(true);
        Invoke("loadNextScene", 1.5f);
    }
    void loadNextScene()
    {
        Destroy(scrimer);
        Destroy(red_light);
        VRLookWalk.IS_scrimer = false;
        loading.SetActive(true);
        SceneManager.LoadScene("2_glav_obs");
    }
}
