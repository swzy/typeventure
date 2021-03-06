﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Health : MonoBehaviour {

	public int startingHealth = 100;                            // The amount of health the player starts the game with.
	public int currentHealth;                                   // The current health the player has.
	public Slider Slider;                                 // Reference to the UI's health bar.

	public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.


	bool isDead;                                                // Whether the player is dead.
	bool damaged;                                               // True when the player gets damaged.


	void Awake ()
	{
		
		// Set the initial health of the player.
		currentHealth = startingHealth;
	}


	void Update ()
	{
		damaged = false;
	}


	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash.
		damaged = true;

		// Reduce the current health by the damage amount.
		currentHealth -= amount ;

		// Set the health bar's value to the current health.
		Slider.value = currentHealth;

		// If the player has lost all it's health and the death flag hasn't been set yet...
		if(currentHealth <= 0 && !isDead)
		{
			// ... it should die.
			Death ();
		}
	}


	void Death ()
	{
		// Set the death flag so this function won't be called again.
		isDead = true;


	}       
}
