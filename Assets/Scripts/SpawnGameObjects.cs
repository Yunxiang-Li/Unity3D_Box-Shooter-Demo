using UnityEngine;
using System.Collections;

/**
 * This class deals with all objects' spawning.
 */
public class SpawnGameObjects : MonoBehaviour
{
	// Public variables
	public float secondsBetweenSpawning = 0.1f;
	public float xMinRange = -25.0f;
	public float xMaxRange = 25.0f;
	public float yMinRange = 8.0f;
	public float yMaxRange = 25.0f;
	public float zMinRange = -25.0f;
	public float zMaxRange = 25.0f;
	public GameObject[] spawnObjects; // what prefabs to spawn

	private float nextSpawnTime;

	// Use this for initialization
	private void Start ()
	{
		// determine when to spawn the next object
		nextSpawnTime = Time.time + secondsBetweenSpawning;
	}
	
	// Update is called once per frame
	private void Update ()
	{
		// Exit if there is a game manager and the game is over
		if (GameManager.gm) {
			if (GameManager.gm.gameIsOver)
				return;
		}

		// Check if time to spawn a new game object
		if (!(Time.time >= nextSpawnTime)) 
			return;
		// Spawn the game object through function below
		MakeThingToSpawn ();

		// Determine the next time to spawn the object
		nextSpawnTime = Time.time + secondsBetweenSpawning;
	}

	private void MakeThingToSpawn ()
	{
		Vector3 spawnPosition;

		// Get a random position between the specified ranges
		spawnPosition.x = Random.Range (xMinRange, xMaxRange);
		spawnPosition.y = Random.Range (yMinRange, yMaxRange);
		spawnPosition.z = Random.Range (zMinRange, zMaxRange);

		// determine which object to spawn
		var objectToSpawn = Random.Range (0, spawnObjects.Length);

		// actually spawn the game object
		var spawnedObject = Instantiate (spawnObjects [objectToSpawn], spawnPosition, transform.rotation) as GameObject;

		// make the parent the spawner so hierarchy doesn't get super messy
		spawnedObject.transform.parent = gameObject.transform;
	}
}
