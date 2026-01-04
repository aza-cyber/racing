using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Manager manager;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("car"))
        {
             manager.completeLevel();
        }
       
    }
}
