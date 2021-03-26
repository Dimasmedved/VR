using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    public Rigidbody rb;
    public float spead = 5;
    Vector3 directionToTarget;
    public static GameObject target = null;

    public bool is_go = false;

    private void Start()
    {
        target = GameObject.Find("trigger_go");
    }
    private void FixedUpdate()
    {
        if (target != null&&is_go==true)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(directionToTarget.x * spead, directionToTarget.y * spead, directionToTarget.z * spead);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "trigger_go")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
