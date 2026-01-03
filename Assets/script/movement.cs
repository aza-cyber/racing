using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forwardSpeed = 15f;
    public float turnSpeed = 5f;

    void FixedUpdate()
    {
        // Move forward continuously
        transform.Translate(Vector3.forward * forwardSpeed * Time.fixedDeltaTime);

        // Left & Right movement
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * turnSpeed * Time.fixedDeltaTime);
    }
}
