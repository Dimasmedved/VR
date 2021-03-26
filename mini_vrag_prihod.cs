using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_vrag_prihod : MonoBehaviour
{
    public Rigidbody rb;
    public float spead = 15;
    Vector3 directionToTarget;
    public static GameObject target = null;
    public static bool run = false;
    void Start()
    {
        target = GameObject.Find("Player");
    }

    void Update()
    {
        if (run)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector3(directionToTarget.x * spead, directionToTarget.y * spead, directionToTarget.z * spead);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
