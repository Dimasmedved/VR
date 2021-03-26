using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_open : MonoBehaviour
{
    
    public GameObject vrag;
   
    public static int a = 0;

    public static int caseta;

   

    //get key
    public GameObject vrag_spawn;
    public GameObject destroy_key;
    public GameObject new_key;
    //glav_KEY
    public bool IS_GRAB_GLAV_KEY=false;

    public static bool is_grabing_key = false;
    public static GameObject KEY;
    public Transform hand;
    public GameObject key;
    //end
    public GameObject Vvrag;
    public GameObject light;
    public GameObject loading;

    //audio
    public AudioSource get_key;
    public AudioSource open_doorAUD;
    public AudioSource rezk_zvuk;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "door"&&door_open.is_grabing_key)
        {
            door_open.open = true;
            Destroy(door_open.KEY);
            open_doorAUD.Play();
            Invoke("AUD", 1f);
        }
        if (hit.gameObject.tag == "door" && right_door_open.is_grabing_key)
        {
            right_door_open.open = true;
            Destroy(right_door_open.KEY);
            open_doorAUD.Play();
            Invoke("AUD", 1f);
        }
        if (hit.gameObject.name == "door_glav" && IS_GRAB_GLAV_KEY)
        {
            open_door.Open = true;
            open_doorAUD.Play();
            Invoke("AUD", 1f);
        }
        if (hit.gameObject.tag == "trigger")
        {
            Destroy(hit.gameObject);
            Destroy(vrag);
            a = 1;
        }
        if (hit.gameObject.tag == "trigger1")
        {
            Destroy(hit.gameObject);
            a = 2;
        }
        if (hit.gameObject.name == "box_kaseta")
        {
            caseta = 1;
        }
        if(hit.gameObject.name== "trigger_scrimer")
        {
            a = 4;
        }
        
        if (hit.gameObject.name == "trigger_get_key")
        {
            rezk_zvuk.Play();
            Destroy(hit.gameObject);
            vrag_spawn.SetActive(true);
            new_key.SetActive(true);
            Destroy(destroy_key,3f);
        }
        if (hit.gameObject.name == "toilet")
        {
            IS_GRAB_GLAV_KEY = true;
        }
        if(hit.gameObject.name== "barrer")
        {
            Vvrag.SetActive(true);
            Destroy(light, 1.2f);
            Invoke("Load_Scene", 1.2f);
        }
    }
    void AUD()
    {
        door_open.is_grabing_key = false;
        right_door_open.is_grabing_key = false;
        IS_GRAB_GLAV_KEY = false;
    }
    void Load_Scene()
    {
        loading.SetActive(true);
        SceneManager.LoadScene("1_glav_obs");
    }
    public void GET_GLAV_KEY()
    {
        if (IS_GRAB_GLAV_KEY)
        {
            Debug.Log("go");
            KEY = Instantiate(key, hand.transform.position, hand.transform.rotation);
            KEY.transform.parent = hand.transform;
            Destroy(key);
            get_key.Play();
        }

    }
}
