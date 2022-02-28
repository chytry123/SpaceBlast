using UnityEngine;

public class AlienGun : MonoBehaviour
{
    public GameObject projectile;
    public float cd_time = 2f;
    private float end_of_cd;
    private bool on_cd = false;

    public void FireProjectile()
    {        
        Quaternion gun_rotation = transform.rotation;
        Instantiate(projectile, transform.position, gun_rotation);
        on_cd = true;
        end_of_cd = Time.time + cd_time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= end_of_cd) on_cd = false;
        if (on_cd == false) FireProjectile();
    }
}
