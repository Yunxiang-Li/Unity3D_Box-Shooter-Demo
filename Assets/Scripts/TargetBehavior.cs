using UnityEngine;
using System.Collections;

/**
 * This class represents the behavior of targets.
 */
public class TargetBehavior : MonoBehaviour
{

	// Target impacts on game
	public int scoreAmount = 0;
	public float timeAmount = 0.0f;

	// Store explosion prefab( will explode when collides with bullet of the player)
	public GameObject explosionPrefab;

	// when collided with another gameObject
	private void OnCollisionEnter(Collision newCollision)
	{
		// exit if there is a game manager and the game is over
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag != "Projectile") 
			return;
		if (explosionPrefab) {
			// Instantiate an explosion effect at the gameObjects position and rotation
			Instantiate (explosionPrefab, transform.position, transform.rotation);
		}

		// if game manager exists, make adjustments based on target properties
		if (GameManager.gm) {
			GameManager.gm.targetHit (scoreAmount, timeAmount);
		}
				
		// destroy the projectile
		Destroy (newCollision.gameObject);
				
		// destroy target itself
		Destroy (gameObject);
	}
}
