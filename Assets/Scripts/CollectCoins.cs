using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    [Tooltip("The particles that appear after the player collects a coin.")]
    public GameObject coinParticles;
    public ScoreManager scoreManager;
    PlayerMovement playerMovementScript;

	private void Start()
	{
		//scoreManager = GetComponent<ScoreManager>();
	}
	
	void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
            playerMovementScript = other.GetComponent<PlayerMovement>();
            playerMovementScript.soundManager.PlayCoinSound();
            ScoreManager.score += 10;
            scoreManager.AddHealth();
			GameObject particles = Instantiate(coinParticles, transform.position, new Quaternion());
            Destroy(gameObject);
        }
    }
}