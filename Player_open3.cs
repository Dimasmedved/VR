using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_open3 : MonoBehaviour
{
    public GameObject box;
    public GameObject eyes;
    public GameObject dead;
    public GameObject BIG_vrag;
    public GameObject BIG_vrag1;
    public GameObject D;
    public GameObject E;
    public GameObject M;
    public GameObject O;

    public GameObject loading;

    public AudioSource scrim;

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "trigger")
        {
            Destroy(hit.gameObject);
            anim_box.go = true;
            Destroy(box,4f);
        }
        if(hit.gameObject.name== "black_men?")
        {
            eyes.SetActive(true);
            Destroy(hit.gameObject);
            VRLookWalk.IS_scrimer = true;
            Destroy(BIG_vrag);
            Invoke("Open_eyes", 2f);
        }
    }
    void Open_eyes()
    {
        eyes.SetActive(false);
        BIG_vrag1.SetActive(true);
        scrim.Play();
        Invoke("Second_Scene", 2f);
       // Invoke("Dead", 2f);
    }
    void Dead()
    {
        dead.SetActive(true);
        Invoke("d", 0.5f);
    }
    void d() {
        D.SetActive(true);
        Invoke("e", 0.5f);
    }
    void e()
    {
        E.SetActive(true);
        Invoke("m", 0.5f);
    }
    void m()
    {
        M.SetActive(true);
        Invoke("o", 0.5f);
    }
    void o()
    {
        O.SetActive(true);
        Invoke("menu", 4f);
    }

    void Second_Scene()
    {
        VRLookWalk.IS_scrimer = false;
        loading.SetActive(true);
        SceneManager.LoadScene("3_glav_obs");
    }
    void menu()
    {
        SceneManager.LoadScene("main_menu");
    }
}
