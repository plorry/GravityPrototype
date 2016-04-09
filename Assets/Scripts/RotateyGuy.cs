using UnityEngine;
using System.Collections;

public class RotateyGuy : MonoBehaviour {
	public Rigidbody rb;
	public GlobalForces forces;

	// Use this for initialization
	public virtual void Start () {
		Physics.gravity = new Vector3(0, -100, 0);
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	public virtual void Update () {
		if (forces.GetDoor()) {
			rb.AddForce(forces.GetForce());
		}
	}

	public void MoveDown() {

	}
}
