using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class voicebox : MonoBehaviour
{
    bool on = false;
    public GameObject loading;
    public AudioSource aud;
  public void ON()
    {
        if (on == false)
        {
            Invoke("Load", 25f);
            aud.Play();
            on = true;
        }
    }
    void Load()
    {
        main_menu.SCENE = 2;
        PlayerPrefs.SetInt("Scene", main_menu.SCENE);
        on = false;
        loading.SetActive(true);
        SceneManager.LoadScene("2_glav");
    }

    public void ON1()
    {
        if (on == false)
        {
            Invoke("Load1", 10f);
            on = true;
        }
    }
    void Load1()
    {
        main_menu.SCENE = 3;
        PlayerPrefs.SetInt("Scene", main_menu.SCENE);
        on = false;
        loading.SetActive(true);
        SceneManager.LoadScene("3_glav");
    }

    public void ON2()
    {
        if (on == false)
        {
            Invoke("Load2", 10f);
            on = true;
        }
    }
    void Load2()
    {
        main_menu.SCENE = 4;
        PlayerPrefs.SetInt("Scene", main_menu.SCENE);
        on = false;
        loading.SetActive(true);
        SceneManager.LoadScene("4_glav");
    }
}
