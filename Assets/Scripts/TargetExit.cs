using UnityEngine;
using System.Collections;

/**
 * This class represents targets' self destruction after a certain time.
 */
public class TargetExit : MonoBehaviour
{
	// Store the time of how long a target can exist in the world
	public float exitAfterSeconds = 10f;
	// Store the time of targets' exit animation
	public float exitAnimationSeconds = 1f; 

	// Store the flag that whether target is able to be destroyed or not.
	private bool startDestroy = false;
	// Each target's remaining time before destroyed.
	private float targetTime;

	// Use this for initialization
	private void Start()
	{
		// set the targetTime to be the current time + exitAfterSeconds seconds
		targetTime = Time.time + exitAfterSeconds;
	}
	
	// Update is called once per frame
	private void Update()
	{
		// continually check to see if past the target time
		if (!(Time.time >= targetTime)) 
			return;
		if (this.GetComponent<Animator>() == null)
			// no Animator so just destroy right away
			Destroy (gameObject);
		else if (!startDestroy) {
			// set startDestroy to true so this code will not run a second time
			startDestroy = true;

			// trigger the Animator to make the "Exit" transition
			this.GetComponent<Animator>().SetTrigger ("Exit");

			// Call KillTarget function after exitAnimationSeconds to give time for animation to play
			Invoke ("KillTarget", exitAnimationSeconds);
		}
	}

	/**
	 * Destroy the gameObject when called
	 */
	private void KillTarget ()
	{
		// remove the gameObject
		Destroy (gameObject);
	}
}
