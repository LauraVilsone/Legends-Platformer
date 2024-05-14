using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
	[Tooltip("Player health")]
	[HideInInspector] public float health;
	public float playerStartingHealth;

	private void Start()
	{
		health = playerStartingHealth;
	}
}
