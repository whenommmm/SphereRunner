using UnityEngine;
using UnityEngine.InputSystem;

public class MovementSp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sideForce = 500f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -0.4)
        {
            FindFirstObjectByType<GameManager>().EndGame();
            FindFirstObjectByType<Score>().enabled = false;
        }
    }
}
