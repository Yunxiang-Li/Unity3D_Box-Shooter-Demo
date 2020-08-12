using System;
using UnityEngine;
using System.Collections;

/**
 * This class represents all move actions of a target.
 */
public class TargetMover : MonoBehaviour {

	// Define the possible states through an enumeration
	public enum motionDirections {Spin, Horizontal, Vertical};
	
	// Store the state
	public motionDirections motionState = motionDirections.Horizontal;

	// motion parameters
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	// Update is called once per frame
	private void Update () {

		// do the appropriate motion based on the motionState
		switch(motionState) {
			case motionDirections.Spin:
				// rotate around the up axis of the gameObject
				gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
				break;
			
			case motionDirections.Vertical:
				// move up and down over time
				gameObject.transform.Translate
					(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
				break;

            case motionDirections.Horizontal:
                // move right and left over time
                gameObject.transform.Translate
	                (Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
                break;
			default:
				throw new ArgumentOutOfRangeException();
		}
	}
}
