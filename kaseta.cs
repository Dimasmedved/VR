using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaseta : MonoBehaviour
{
    public static bool Is_muz = false;
    public bool Plaingcaset1 = false;
    public AudioSource cas1;
    public void caseta1()
    {
        if (Player_open.caseta == 1&&Plaingcaset1==false)
        {
            Is_muz = true;
            cas1.Play();
            Plaingcaset1 = true;
        }
    }
}
