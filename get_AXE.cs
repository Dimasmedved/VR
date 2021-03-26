using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_AXE : MonoBehaviour
{
    public GameObject hand;

    public static GameObject AXE;
    public static bool is_grab_axe;
    public void Get_axe()
    {
        if (is_grab_axe == false)
        {
            AXE = Instantiate(gameObject, hand.transform.position, hand.transform.rotation);
            AXE.transform.parent = hand.transform;
            Destroy(gameObject);
            is_grab_axe = true;
            AXE.transform.Rotate(0, -90, 90);
            AXE.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);

        }
    }
}
