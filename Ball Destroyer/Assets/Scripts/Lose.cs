using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    private Ball ball;
	private GameManager gameManager;
	
	IEnumerator Pause()
	{
		print("Before Waiting 2 seconds");
		gameManager = GameObject.FindObjectOfType<GameManager>();
		gameManager.SwitchState (GameState.Failed);
		
		yield return new WaitForSeconds(2);
		
		ball = GameObject.FindObjectOfType<Ball>();
		ball.gameStarted = false;
		
		Application.LoadLevel(Application.loadedLevel);
		print("After Waiting 2 Seconds");
	}
	
	void OnTriggerEnter2D (Collider2D trigger)
	{
		print ("Lost Triggered!");
		
		StartCoroutine(Pause());
	}
}
