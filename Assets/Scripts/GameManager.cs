using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/**
 * This class represents the game manager which will control the main process of the game.
 */
public class GameManager : MonoBehaviour {

	// make game manager public static so we can access this from other scripts
	public static GameManager gm;

	// public fields
	public int score = 0;
	public bool canBeatLevel = false;
	public int beatLevelScore = 0;
	public float startTime = 5.0f;
	
	public Text mainScoreDisplay;
	public Text mainTimerDisplay;

	// Store scores we earn
	public GameObject gameOverScoreOutline;

	public AudioSource musicAudioSource;

	public bool gameIsOver = false;

	public GameObject playAgainButtons;
	public string playAgainLevelToLoad;

	public GameObject nextLevelButtons;
	public string nextLevelToLoad;

	private float currentTime;

	// setup the game
	private void Start () {

		// set the current time to the startTime specified
		currentTime = startTime;

		// get a reference to the GameManager component for use by other scripts
		if (gm == null) 
			gm = this.gameObject.GetComponent<GameManager>();

		// init scoreboard to 0
		mainScoreDisplay.text = "0";

		// inactivate the gameOverScoreOutline gameObject, if it is set
		if (gameOverScoreOutline)
			gameOverScoreOutline.SetActive (false);

		// inactivate the playAgainButtons gameObject, if it is set
		if (playAgainButtons)
			playAgainButtons.SetActive (false);

		// inactivate the nextLevelButtons gameObject, if it is set
		if (nextLevelButtons)
			nextLevelButtons.SetActive (false);
	}

	// this is the main game event loop
	private void Update ()
	{
		// If game is over, do nothing.
		if (gameIsOver) 
			return;
		// Check to see if the player win the level.
		if (canBeatLevel && (score >= beatLevelScore)) {  
			BeatLevel();
		} 
		// Check to see if timer has ran out
		else if (currentTime < 0) {
			EndGame();
		} 
		// Game is still in playing state, so update the timer.
		else { 
			currentTime -= Time.deltaTime;
			mainTimerDisplay.text = currentTime.ToString ("0.00");				
		}
	}

	// Called when time is over and the player loses.
	private void EndGame() {
		// Game is over
		gameIsOver = true;

		// Display the game over message.
		mainTimerDisplay.text = "GAME OVER";

		// Activate the gameOverScoreOutline gameObject, if it is set 
		if (gameOverScoreOutline)
			gameOverScoreOutline.SetActive (true);
	
		// activate the playAgainButtons gameObject, if it is set 
		if (playAgainButtons)
			playAgainButtons.SetActive (true);

		// reduce the pitch of the background music, if it is set 
		if (musicAudioSource)
			// slow down the music
			musicAudioSource.pitch = 0.5f; 
	}

	// Called when the player beats the current level.
	private void BeatLevel() {
		// game is over
		gameIsOver = true;

		// Display the victory message.
		mainTimerDisplay.text = "LEVEL COMPLETE";

		// activate the gameOverScoreOutline gameObject, if it is set 
		if (gameOverScoreOutline)
			gameOverScoreOutline.SetActive (true);

		// activate the nextLevelButtons gameObject, if it is set 
		if (nextLevelButtons)
			nextLevelButtons.SetActive (true);
		
		// reduce the pitch of the background music, if it is set 
		if (musicAudioSource)
			musicAudioSource.pitch = 0.5f; // slow down the music
	}

	// Called to update the score or time
	public void targetHit (int scoreAmount, float timeAmount)
	{
		// Increase the score by the scoreAmount and update the text UI
		score += scoreAmount;
		mainScoreDisplay.text = score.ToString ();
		
		// Increase the time by the timeAmount
		currentTime += timeAmount;
		
		// Don't let it go negative
		if (currentTime < 0)
			currentTime = 0.0f;

		// Update the text UI
		mainTimerDisplay.text = currentTime.ToString ("0.00");
	}

	// Called to restart the game.
	public void RestartGame ()
	{
		// We are just loading a scene (or reloading this scene)
		// which is an easy way to restart the level
        SceneManager.LoadScene(playAgainLevelToLoad);
	}

	// Called to go to the next level of the game.
	public void NextLevel ()
	{
		// We are just loading the specified next level (scene)
        SceneManager.LoadScene(nextLevelToLoad);
	}
	

}
