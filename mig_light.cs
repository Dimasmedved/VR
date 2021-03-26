using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mig_light : MonoBehaviour
{
    public Light light;
    private float curTime = 0;
    void Start()
    {
        curTime = Time.time;
    }
    void Update()
    {
        int a = Random.Range(1, 2);
        curTime += Time.deltaTime;
        if (curTime / a >= 1|| curTime / a <= 3)
        {
            light.enabled = !light.enabled;
            curTime = 0;
        }
    }
}
