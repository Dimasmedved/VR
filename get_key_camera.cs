using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_key_camera : MonoBehaviour
{
    public GameObject hand;

    public static GameObject KEY;
    public static bool is_grab_key;
    public void Get_key()
    {
        KEY = Instantiate(gameObject, hand.transform.position, hand.transform.rotation);
        KEY.transform.parent = hand.transform;
        Destroy(gameObject);
        is_grab_key = true;
        KEY.gameObject.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
    }
}
