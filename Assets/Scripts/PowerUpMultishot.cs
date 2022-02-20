using UnityEngine;

public class PowerUpMultishot : MonoBehaviour
{
    public GameObject asteroid;
    public float buff_duration = 5f;
    float t = 0;
    bool colected = false;
    GameObject ui, btn_fire, btn_multishot;

    private void Start()
    {
        ui = GameObject.Find("UI");
        btn_fire = ui.transform.Find("btnFire").gameObject;
        btn_multishot = ui.transform.Find("btnFireMultishot").gameObject;
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GetComponent<AudioSource>().enabled = true;
            GetComponent<MeshRenderer>().enabled = false;
            transform.Find("vfx").gameObject.SetActive(false);
            btn_fire.SetActive(false);
            btn_multishot.SetActive(true);
            t = Time.time;
            colected = true;
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, (-asteroid.GetComponent<ObstacleMovement>().speed - Time.timeSinceLevelLoad * 10) * Time.deltaTime);

        if (colected && Time.time - t > buff_duration)
        {
            btn_fire.SetActive(true);
            btn_multishot.SetActive(false);
            colected = false;
        }
        
        if (colected == false && transform.position.z < -20) Destroy(gameObject);
    }
}
