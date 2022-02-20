using UnityEngine;

public class BarrierCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Enemy"))
        {
            collider.GetComponent<MeshCollider>().enabled = false;
            collider.GetComponent<MeshRenderer>().enabled = false;
            collider.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
