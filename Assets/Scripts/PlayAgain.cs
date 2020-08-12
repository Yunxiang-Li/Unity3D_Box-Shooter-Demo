using UnityEngine;
using System.Collections;

/**
 * This class represents actions after player shoots the restart button.
 */
public class PlayAgain : MonoBehaviour {

	// Respond on collisions
	private void OnCollisionEnter(Collision newCollision)
	{
		// Only do stuff if hit by a projectile(player's bullet).
		if (newCollision.gameObject.tag == "Projectile") {
			// Call the RestartGame function in the game manager
			GameManager.gm.RestartGame();
		}
	}
}
