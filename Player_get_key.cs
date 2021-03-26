using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_get_key : MonoBehaviour
{
    public bool is_box = false;

    public static bool Is_dialog = false;

    public static GameObject KEY;
    public Transform hand;
    public GameObject key;

    public AudioSource Get_key;
    public AudioSource openDoor;
    public bool is_soundOpen=true;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.name == "box")
        {
            is_box = true;
        }
        if (hit.gameObject.name == "door"&&is_soundOpen)
        {
            door.open_door = true;
            openDoor.Play();
            is_soundOpen = false;
        }
    }
    public void get_key() 
    {
        if (is_box)
        {
            KEY = Instantiate(key, hand.transform.position, hand.transform.rotation);
            KEY.transform.parent = hand.transform;
            Destroy(key);
            Is_dialog=true;
            Get_key.Play();
        }
    }
}

