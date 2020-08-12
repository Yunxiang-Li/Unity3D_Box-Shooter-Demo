using UnityEngine;
using System.Collections;

/**
 * This class represents actions after player shoots the next level button.
 */
public class NextLevel : MonoBehaviour {

	// respond on collisions
	private void OnCollisionEnter(Collision newCollision)
	{
		// Only do stuff if hit by a projectile(player's bullet).
		if (newCollision.gameObject.CompareTag("Projectile")) {
			// call the NextLevel function in the game manager
			GameManager.gm.NextLevel();
		}
	}
}
