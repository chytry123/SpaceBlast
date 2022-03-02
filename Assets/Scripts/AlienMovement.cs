using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [SerializeField] [Range(0f, 1f)] float wait_time = 0.6f;
    public float lerp_time = 0.5f, moving_radius = 5f, speed, max_side_velocity;
    private float t = 0f, x, y;
    Vector2 xy;
    Vector3 random_position;
    public Rigidbody rb;

    private void Start()
    {
        //random_position = transform.position;
        transform.Rotate(0, 180, 0);
        x = Random.Range(0f, max_side_velocity);
        y = max_side_velocity - x;
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        //transform.position = Vector3.Lerp(
        //    transform.position,
        //    random_position,
        //    lerp_time * Time.deltaTime);

        //t = Mathf.Lerp(t, 1f, lerp_time * Time.deltaTime);

        //if (t > wait_time)
        //{
        //    t = 0f;
        //    xy = Random.insideUnitCircle.normalized * moving_radius;
        //    //random_position = new Vector3(Random.Range(-moving_radius, moving_radius), Random.Range(-moving_radius, moving_radius), transform.position.z);
        //    random_position = new Vector3(xy.x, xy.y, transform.position.z);
        //}
        if (transform.position.x >= 10 |
            transform.position.x <= -10 |
            transform.position.y >= 5 |
            transform.position.y <= -5)
        {
            x = Random.Range(0f, max_side_velocity);
            y = max_side_velocity - x;
            if (transform.position.x > 0) x = -x;
            if (transform.position.y > 0) y = -y;
        }

        rb.AddForce(x * Time.deltaTime, y * Time.deltaTime, (-speed - Time.timeSinceLevelLoad * 30) * Time.deltaTime);

        if (transform.position.z < 150f) transform.Find("Gun").gameObject.SetActive(true);
        if (transform.position.z < 0) Destroy(gameObject);
    }
}