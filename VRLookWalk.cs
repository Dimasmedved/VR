using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    //scrimer
    public static bool IS_scrimer = false;
    //audio
    public AudioSource walk;
    public bool Is_walk = false;


    private CharacterController cc;

   
    
    void Start()
    {
       
        cc = GetComponent<CharacterController>();
       
    }

  
    void Update()
    {
        

        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f&&IS_scrimer==false)
        {
            moveForward = true;
            if (Is_walk == false)
            {
                walk.Play();
                Is_walk = true;
            }
        }
        else
        {
            moveForward = false;
            walk.Pause();
            Is_walk = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
            
        }
    }
    
    
}
