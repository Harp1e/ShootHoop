using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

    private Camera camera;
    private float rotationSpeed = 3.0f;

    // Use this for initialization
    void Start () {
        camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0);
        camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
    }
}
