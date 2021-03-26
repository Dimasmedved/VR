using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Button_scripts : MonoBehaviour
{
    //Выбор 
    public GameObject vibor;
    public static bool an = false;
    public GameObject light;
    public GameObject loading;
    public GameObject text_peredves;

    public static bool GO = false;

    public static float time = 0;
    public bool Is_enterNO = false;
    public bool Is_enterYES = false;
    public bool IS_go = false;


    public GameObject plane;
    public GameObject anim_scene;

    public Slider load;
    private void Start()
    {
      
        time = Time.time;
        if (time > 0)
        {
            time = 0;
        }
    }
    private void Update()
    {
        if (Is_enterYES)
        {
            time += Time.deltaTime;
            if (time / 1 >= 1)
            {
                Destroy(vibor);
     
                light.SetActive(true);
                GO = true;
                text_peredves.SetActive(true);
                load.gameObject.SetActive(false);
                plane.SetActive(true);
                Destroy(anim_scene);
            }
        }
        if (Is_enterNO)
        {
            time += Time.deltaTime;
            if (time / 1 >= 1)
            {
                time = 0;
                Destroy(vibor);
                GO = true;
                loading.SetActive(true);
                load.gameObject.SetActive(false);
                main_menu.SCENE = 1;
                PlayerPrefs.SetInt("Scene", main_menu.SCENE);
                SceneManager.LoadScene("1_glav");
                IS_go = false;
                
            }
        }
        load.value = time;

    }
    public void NO()
    {
        Is_enterNO = true;
        load.gameObject.SetActive(true);
    }
    public void No_EXIT()
    {
        Is_enterNO = false;
        Is_enterYES = false;
        time = 0;
        IS_go = false;
        load.gameObject.SetActive(false);
    }
    public void YES()
    {
        Is_enterYES = true;
        load.gameObject.SetActive(true);
       
    }
    

}
