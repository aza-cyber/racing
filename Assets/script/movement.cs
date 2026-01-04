using UnityEngine;

public class Movement : MonoBehaviour
{
    public float forwardSpeed = 15f;
    public float turnSpeed = 5f;

    // Road boundaries
    public float leftBoundaryX = -5f;
    public float rightBoundaryX = 5f;

    [System.Obsolete]
    void FixedUpdate()
    {
        // Move forward continuously
        transform.Translate(Vector3.forward * forwardSpeed * Time.fixedDeltaTime);

        // Left & Right movement
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * turnSpeed * Time.fixedDeltaTime);

        // Check if player is out of road
        if (transform.position.x < leftBoundaryX || transform.position.x > rightBoundaryX)
        {
            Debug.Log("Out of road!");
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
