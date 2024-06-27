using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "VerticalPlanes")
        {
            gameObject.SetActive(false);
        }
    }
}
