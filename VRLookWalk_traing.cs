using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VRLookWalk_traing : MonoBehaviour
{

    public Transform vrCamera;
    public float toggleAngle = 30.0f;
    public float speed = 3.0f;
    public bool moveForward;
    //audio
    public AudioSource walk;
    public bool IS_walk = false;
    

    private CharacterController cc;


    //обучение
    public bool time_over = false;

    public float curTime;
    public static int muz = 0;
    public GameObject box;
    public GameObject Door;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;

    public GameObject loading;
    void Start()
    {
        curTime = Time.time;
        cc = GetComponent<CharacterController>();
        if (curTime > 0)
        {
            curTime = 0;
        }
    }

   
    void Update()
    {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f && Button_scripts.GO)
        {
            moveForward = true;
            if (IS_walk==false)
            {
                walk.Play();
                IS_walk = true;
            }
            if(time_over==false){
                curTime += Time.deltaTime;
                if (curTime / 3 >= 1)
                {
                    Text1.SetActive(false);
                    Text2.SetActive(true);
                    box.SetActive(true);
                    muz = 1;
                    curTime = 0;
                    time_over = true;
                }
            }
        }
        else
        {
            moveForward = false;
            walk.Stop();
            IS_walk = false;
        }

        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

            cc.SimpleMove(forward * speed);
            
        }
        
        if (Player_get_key.Is_dialog&&door.open_door==false)
        {
            Text2.SetActive(false);
            Text3.SetActive(true);
            Door.SetActive(true);

        }
        if (door.open_door)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
            Text4.SetActive(true);
            curTime += Time.deltaTime;
            if (curTime / 3 >= 1)
            {
                Text4.SetActive(false);
                loading.SetActive(true);
                main_menu.SCENE = 1;
                PlayerPrefs.SetInt("Scene", main_menu.SCENE);
                SceneManager.LoadScene("1_glav");
                curTime = 0;

            }
        }

    }
   
}
