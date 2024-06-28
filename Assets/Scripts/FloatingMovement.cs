using UnityEngine;

public class FloatingMovement : MonoBehaviour
{
    public float floatSpeed = 1.0f;  // Speed of floating movement
    public float floatAmount = 0.5f; // Amount of floating movement

    private Vector3 startPos;        // Starting position of the object

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Calculate the floating movement using sine function
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        // Update the object's position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
