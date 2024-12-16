using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Input.gyro.enabled = true;
        Debug.Log(Input.location.isEnabledByUser);
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180.0f, Vector3.forward);
        // Debug.Log(Quaternion.AngleAxis(90.0f, Vector3.right) * Input.gyro.attitude * Quaternion.AngleAxis(180.0f, Vector3.forward));

        // transform.position = new Vector3(transform.position.x + Input.acceleration.x, transform.position.y, transform.position.z);
        // Debug.Log(Input.acceleration);

        // Debug.Log(Input.location.lastData);
        Debug.Log(Input.location.status);
    }
}
