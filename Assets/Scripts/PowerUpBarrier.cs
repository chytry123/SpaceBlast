using UnityEngine;

public class PowerUpBarrier : MonoBehaviour
{
    public GameObject asteroid;
    public float buff_duration = 5f, blinking_threshold = 2f;
    float t = 0, blink_t = 0;
    private bool collected = false, turn_on_off = false;
    GameObject player_barrier;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GetComponent<AudioSource>().enabled = true;
            GetComponent<MeshRenderer>().enabled = false;
            transform.Find("vfx").gameObject.SetActive(false);
            player_barrier = collider.transform.Find("ForceField").gameObject;
            player_barrier.SetActive(true);
            t = Time.time;
            collected = true;
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, (-asteroid.GetComponent<ObstacleMovement>().speed - Time.timeSinceLevelLoad * 10) * Time.deltaTime);

        if (collected && 
            Time.time - t > buff_duration - blinking_threshold && 
            Time.time - t < buff_duration && 
            Time.time - blink_t > 0.5f)
        {
            player_barrier.GetComponent<MeshRenderer>().enabled = turn_on_off;
            turn_on_off = !turn_on_off;
            blink_t = Time.time;
        }

        // Turn off barrier after <buff_duration> time
        if (collected && Time.time - t > buff_duration)
        {
            player_barrier.SetActive(false);
            collected = false;
        }

        // Destroy powerup object if not collected
        if (collected == false && transform.position.z < -20) Destroy(gameObject);
    }
}
