using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovemntMainMenu : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    float scale;

    private void Start()
    {
        scale = Random.Range(1f, 3f);
        transform.localScale = new Vector3(scale, scale, scale);
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -speed, ForceMode.VelocityChange);

        if (transform.position.z < -10) Destroy(gameObject);
    }
}
