using UnityEngine;

public class OutOfRoad : MonoBehaviour
{
    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            Debug.Log("OUT OF ROAD");
            FindObjectOfType<Manager>().EndGame();
        }
    }
}
