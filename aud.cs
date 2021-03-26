using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aud : MonoBehaviour
{
    public AudioSource Text1;
    public AudioSource Text2;
    private float curTime = 0;
    void Start()
    {
        curTime = Time.time;
    }
    void Update()
    {
        if (Button_scripts.an)
        {
            Text1.Play();
            curTime += Time.deltaTime;
            if (curTime / 1>= 1)
            {

                Button_scripts.an = false;
                curTime = 0;
            }

        }
        if (VRLookWalk_traing.muz == 1)
        {
            Text2.Play();
            curTime += Time.deltaTime;
            if (curTime / 1 >= 1)
            {

                VRLookWalk_traing.muz = 0;
            }
        }
    }
}
