using UnityEngine;

public class PowerUpBarrier : MonoBehaviour
{
    public GameObject asteroid;
    public float buff_duration = 5f;
    float t = 0;
    bool colected = false;
    GameObject player;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GetComponent<AudioSource>().enabled = true;
            GetComponent<MeshRenderer>().enabled = false;
            transform.Find("vfx").gameObject.SetActive(false);
            player = collider.transform.Find("ForceField").gameObject;
            player.SetActive(true);
            t = Time.time;
            colected = true;
        }
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, (-asteroid.GetComponent<ObstacleMovement>().speed - Time.timeSinceLevelLoad * 10) * Time.deltaTime);

        if (colected && Time.time - t > buff_duration)
        {
            player.SetActive(false);
            colected = false;
        }

        if (colected == false && transform.position.z < -20) Destroy(gameObject);
    }
}
