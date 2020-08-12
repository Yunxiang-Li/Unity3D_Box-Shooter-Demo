using UnityEngine;
using System.Collections;

/**
 * This class represents all shooting actions of the player.
 */
public class Shooter : MonoBehaviour {

	// Reference to projectile prefab to shoot
	public GameObject projectile;
	public float power = 10.0f;
	
	// Reference to AudioClip to play
	public AudioClip shootSFX;
	
	// Update is called once per frame
	private void Update ()
	{
		// Detect if fire button is pressed
		if (!Input.GetButtonDown("Fire1") && !Input.GetButtonDown("Jump"))
			return;
		// Check if projectile is specified
		if (!projectile)
			return;
		// Instantiate projectile at the camera + 1 meter forward with camera rotation
		var newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation)
			as GameObject;

		// if the projectile does not have a rigidbody component, add one
		if (!newProjectile.GetComponent<Rigidbody>()) 
		{
			newProjectile.AddComponent<Rigidbody>();
		}
		// Apply force to the newProjectile's Rigidbody component if it has one
		newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * power, ForceMode.VelocityChange);
				
		// Play sound effect if set
		if (!shootSFX) 
			return;
		// If the projectile has an AudioSource component
		if (newProjectile.GetComponent<AudioSource> ()) { 
			// Play the sound clip through the AudioSource component on the gameobject.
			// note: The audio will travel with the gameobject.
			newProjectile.GetComponent<AudioSource> ().PlayOneShot (shootSFX);
		} 
		else {
			// dynamically create a new gameObject with an AudioSource
			// this automatically destroys itself once the audio is done
			AudioSource.PlayClipAtPoint (shootSFX, newProjectile.transform.position);
		}
	}
}
