using UnityEngine;

public class AlienMovement : MonoBehaviour
{
    [SerializeField] [Range(0f, 1f)] float wait_time = 0.6f;
    public float lerp_time = 0.5f, moving_radius = 5f;
    private float t = 0f;
    Vector2 xy;
    Vector3 random_position;

    private void Start()
    {
        random_position = transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.position = Vector3.Lerp(
            transform.position,
            random_position,
            lerp_time * Time.deltaTime);
        
        t = Mathf.Lerp(t, 1f, lerp_time * Time.deltaTime);

        if (t > wait_time)
        {
            t = 0f;
            xy = Random.insideUnitCircle.normalized * moving_radius;
            //random_position = new Vector3(Random.Range(-moving_radius, moving_radius), Random.Range(-moving_radius, moving_radius), transform.position.z);
            random_position = new Vector3(xy.x, xy.y, transform.position.z);
        }
    }
}
