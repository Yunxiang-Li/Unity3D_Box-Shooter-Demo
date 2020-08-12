using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	// public variables
	public float moveSpeed = 3.0f;
	public float gravity = 9.81f;

	private CharacterController myController;

	// Use this for initialization
	private void Start () {
		// store a reference to the CharacterController component on this gameObject
		// it is much more efficient to use GetComponent() once in Start and store
		// the result rather than continually use GetComponent() in the Update function
		myController = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	private void Update () {
		// Determine how much should move in the z-direction
		var movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;

		// Determine how much should move in the x-direction
		var movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;

		// Convert combined Vector3 from local space to world space based on the position of the current
		// game object (player)
		var movement = transform.TransformDirection(movementZ + movementX);
		
		// Apply gravity (so the object will fall if not grounded)
		movement.y -= gravity * Time.deltaTime;

		// Used for debugging
		//Debug.Log ("Movement Vector = " + movement);

		// Actually move the character controller in the movement direction
		myController.Move(movement);
	}
}
