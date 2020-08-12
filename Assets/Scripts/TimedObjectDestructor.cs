using UnityEngine;
using System.Collections;

/**
 * This class represents the destruction of bullets and all explosions.
 */
public class TimedObjectDestructor : MonoBehaviour {

	// Effect lasting time.
	public float timeOut = 1.0f;
	// Whether current gameobject has children or not.
	public bool detachChildren = false;

	// Use this for initialization
	private void Awake () {
		// Invoke the DestroyNow function to run after timeOut seconds
		Invoke ("DestroyNow", timeOut);
	}
	

	/**
	 * Check for children objects and destroy the current game objects.
	 */
	private void DestroyNow ()
	{
		// Detach the children before destroying if specified
		if (detachChildren) { 
			transform.DetachChildren();
		}

		// Destroy the game Object
		Destroy(gameObject);
	}
}
