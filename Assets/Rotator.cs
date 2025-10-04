using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 90f; // Degrees per second
    private int direction = 1; // 1 = clockwise, -1 = counter-clockwise

    void Update()
    {
        // Rotate the circle continuously
        transform.Rotate(0f, 0f, direction * rotationSpeed * Time.deltaTime);

        // Toggle direction when spacebar is pressed or mouse clicked
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction *= -1; // Flip direction
        }
    }
}
