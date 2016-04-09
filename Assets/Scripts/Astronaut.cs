using UnityEngine;
using System.Collections;

public class Astronaut : RotateyGuy {
	private Vector3 newPosition;

	// Use this for initialization
	public override void Start () {
		base.Start ();
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			newPosition = new Vector3(rb.position[0], rb.position[1], rb.position[2] - 5);
			rb.MovePosition(newPosition);
		}

	}
}
