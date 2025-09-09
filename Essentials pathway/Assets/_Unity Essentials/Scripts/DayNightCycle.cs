using UnityEngine;

[ExecuteAlways] // Optional: so you can preview in editor
public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Time (in seconds) for a full day/night cycle")]
    public float dayLengthInSeconds = 120f; // default: 2 minutes for a full cycle

    private float rotationSpeed;

    void Start()
    {
        // 360 degrees per full cycle
        rotationSpeed = 360f / dayLengthInSeconds;
    }

    void Update()
    {
        if (dayLengthInSeconds <= 0) return;

        // Update speed if value is changed in Inspector at runtime
        rotationSpeed = 360f / dayLengthInSeconds;

        // Rotate around the X axis to simulate sun rising/setting
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
