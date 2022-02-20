using UnityEngine.UI;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject projectile;
    public Image img_onCD;
    public Button btn_fire;
    public float cd_time = 3f;
    private bool on_cd = false;
    private float time_remaining = 0f, end_of_cd = 0f;

    public void FireProjectile()
    {
        Quaternion gun_rotation = transform.rotation;
        Instantiate(projectile, transform.position, gun_rotation);
        on_cd = true;
        time_remaining = cd_time;
        end_of_cd = Time.time + cd_time;
        btn_fire.GetComponent<Button>().interactable = false;
    }

    public void FixedUpdate()
    {
        if(on_cd)
        {
            img_onCD.fillAmount = 1 - (cd_time - time_remaining) / cd_time;
            time_remaining = end_of_cd - Time.time;

            if (time_remaining <= 0)
            {
                on_cd = false;
                btn_fire.GetComponent<Button>().interactable = true;
            }
        }
    }
}
