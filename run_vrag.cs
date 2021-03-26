using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run_vrag : MonoBehaviour
{
    public Animator anim;
    public GameObject target = null;

    public Rigidbody rb;
    public float spead = 10;
    Vector3 directionToTarget;
    private void Update()
    {
        if (Player_open.a == 4)
        {
            anim.SetBool("Is_fust", true);
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(directionToTarget.x * spead, directionToTarget.y * spead, directionToTarget.z * spead);
        }
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "trigger_scrimer")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);

        }
    }
}
