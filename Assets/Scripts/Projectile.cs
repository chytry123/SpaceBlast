using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10000;
    public GameObject explosion, vfx;
    float t;

    private void Start()
    {
        t = Time.time;
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, speed * Time.deltaTime);

        if (transform.position.z > 200f) GetComponent<Collider>().enabled = false;
        if (Time.time - t > 5f) Destroy(gameObject);    // Destroy after 5s to avoid interrupting explosion sound
    }

    void OnCollisionEnter(Collision collision)
    {
        vfx.SetActive(false);
        explosion.SetActive(true);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        //Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
