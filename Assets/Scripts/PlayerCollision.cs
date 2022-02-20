using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameObject explosion, fire;
    //public AudioSource colissionAudio;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Cage")
        {
            movement.enabled = false;
            explosion.SetActive(true);
            fire.SetActive(false);
            GameObject.Find("Player").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("Player").GetComponent<MeshCollider>().enabled = false;
            GetComponent<AudioSource>().enabled = false;
            //colissionAudio.Play();
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}