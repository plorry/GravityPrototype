using UnityEngine;
using System.Collections;

public class GlobalForces : MonoBehaviour {
	private bool door_open = false;
	private Vector3 door_force = new Vector3(-200, 0, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			OpenDoor ();
		} else if (Input.GetKeyUp (KeyCode.Space)) {
			CloseDoor();
		}
	}

	public void OpenDoor() {
		door_open = true;
	}

	public void CloseDoor() {
		door_open = false;
	}

	public bool GetDoor() {
		return door_open;
	}

	public Vector3 GetForce() {
		return door_force;
	}
}
