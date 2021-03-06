using UnityEngine;

public class ObstacleMovement : MonoBehaviour
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
        rb.AddForce(0, 0, (-speed - Time.timeSinceLevelLoad * 30) * Time.deltaTime);

        // Asteroid becomes transparent when it's close to camera
        if (transform.position.z < 10)
        {
            transform.Find("mesh_transparent").gameObject.SetActive(true);
            transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
        }

        if (transform.position.z < -30) Destroy(gameObject);
    }
}
