using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    float turn_strenght = 0.8f;
    public VariableJoystick variableJoystick;
    public Animator animator;

    void FixedUpdate()
    {
        if (Input.GetKey("d") && rb.position.x < 7.5f)
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            animator.SetBool("turn_right", true);
        }

        else
        {
            animator.SetBool("turn_right", false);
        }

        if (Input.GetKey("a") && rb.position.x > -7.5f)
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            animator.SetBool("turn_left", true);
        }

        else
        {
            animator.SetBool("turn_left", false);
        }

        if (Input.GetKey("w") && rb.position.y < 3f)
        {
            rb.AddForce(0, speed * Time.deltaTime, 0, ForceMode.VelocityChange);
            animator.SetBool("turn_up", true);
        }

        else
        {
            animator.SetBool("turn_up", false);
        }

        if (Input.GetKey("s") && rb.position.y > -3f)
        {
            rb.AddForce(0, -speed * Time.deltaTime, 0, ForceMode.VelocityChange);
            animator.SetBool("turn_down", true);
        }

        else
        {
            animator.SetBool("turn_down", false);
        }

        Vector3 direction = Vector3.up * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;

        if (direction.x > turn_strenght) animator.SetBool("turn_right", true);
        else animator.SetBool("turn_right", false);

        if (direction.x < -turn_strenght) animator.SetBool("turn_left", true);
        else animator.SetBool("turn_left", false);

        if (direction.y > turn_strenght && direction.x < turn_strenght && direction.x > -turn_strenght) animator.SetBool("turn_up", true);
        else animator.SetBool("turn_up", false);

        if (direction.y < -turn_strenght && direction.x < turn_strenght && direction.x > -turn_strenght) animator.SetBool("turn_down", true);
        else animator.SetBool("turn_down", false);

        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}