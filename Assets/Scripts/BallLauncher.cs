using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;
	public GameObject court;

	private Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		if (court != null) {
			if (Input.GetButtonDown("Fire1")) {
            	GameObject instance = Instantiate(ballPrefab);
            	instance.transform.position = camera.transform.position;
            	Rigidbody rb = instance.GetComponent<Rigidbody>();
            	rb.velocity = camera.transform.rotation * Vector3.forward * ballSpeed;
            }
        }
	}
}
