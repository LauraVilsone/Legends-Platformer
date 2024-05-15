using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
	public Slider healthSlider;
	[HideInInspector] 
	public float health;
	public float playerStartingHealth;

	private void Start()
	{
		health = playerStartingHealth;
		healthSlider.value = playerStartingHealth;
	}

	public void UpdateHealthUI()
	{
		healthSlider.value = health;
	}
}
