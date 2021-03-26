using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_vrag_uxod : MonoBehaviour
{
    public Rigidbody rb;
    public float spead = 5;
    Vector3 directionToTarget;
    public static GameObject target = null;

    public Animator anim;

    bool run = false;
    void Start()
    {
        target = GameObject.Find("uxod");
    }

    
    void Update()
    {
        if (Player_open.a == 2&&run==false)
        {
            gameObject.transform.Rotate(0, 90, 0);
            anim.SetBool("Is_run", true);
            run = true;
           
        }
    }
    private void FixedUpdate()
    {
        if (run)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(directionToTarget.x * spead, directionToTarget.y * spead, directionToTarget.z * spead);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "uxod")
        {
            Destroy(gameObject);
        }
    }

}
