using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class main_menu : MonoBehaviour
{
    public GameObject loading;
    public float time_menu;
    public bool is_enter = false;
    public Slider load;
    public bool is_new_game = false;
    public bool Play_game = false;
    //save
    public static int SCENE = 0;

    private void Start()
    {
        SCENE=PlayerPrefs.GetInt("Scene");
        time_menu = Time.time;
        if (time_menu > 0)
        {
            time_menu = 0;
        }
    }
    private void Update()
    {
        if (is_enter)
        {
            time_menu += Time.deltaTime;
            if (time_menu / 1 >= 1)
            {
                Application.Quit();
                Debug.Log("exit");
            }
        }
        if (is_new_game)
        {
            time_menu += Time.deltaTime;
            if (time_menu / 1 >= 1)
            {
                PlayerPrefs.DeleteAll();
                loading.SetActive(true);
                SceneManager.LoadScene("training");
            }
        }
        if (Play_game)
        {
            time_menu += Time.deltaTime;
            if (time_menu / 1 >= 1)
            {
                SCENE = PlayerPrefs.GetInt("Scene");
                loading.SetActive(true);
                if (SCENE == 1)
                {
                    SceneManager.LoadScene("1_glav");
                }
                else if (SCENE == 2)
                {
                    SceneManager.LoadScene("2_glav");
                }
                else if (SCENE == 3)
                {
                    SceneManager.LoadScene("3_glav");
                }
                else if (SCENE == 4)
                {
                    SceneManager.LoadScene("4_glav");
                }
                else
                {
                    SceneManager.LoadScene("training");
                }
            }
        }
        load.value = time_menu;
    }
    public void NEW_Game()
    {
        is_new_game = true;
        load.gameObject.SetActive(true);
    }
    public void Play()
    {
        Play_game = true;
        load.gameObject.SetActive(true);
    }


    public void EXIT()
    {
        is_enter = true;
        
        load.gameObject.SetActive(true);
    }
    public void exit()
    {
        time_menu = 0;
        is_enter = false;
        is_new_game = false;
        Play_game = false;
        load.gameObject.SetActive(false);
    }

}
