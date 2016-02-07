﻿using UnityEngine;
using System.Collections;

public class Unit : MonoBehaviour {

	public int startingHealth = 100;            // The amount of health the enemy starts the game with.
	public int currentHealth;                   // The current health the enemy has.

	bool isDead;                                // Whether the enemy is dead.

	public void TakeDamage (int amount, Vector3 hitPoint)
	{
		// If the enemy is dead...
		if(isDead)
			// ... no need to take damage so exit the function.
			return;
		
		// Play the hurt sound effect.
//		enemyAudio.Play ();
		
		// Reduce the current health by the amount of damage sustained.
		currentHealth -= amount;
		
		// Set the position of the particle system to where the hit was sustained.
//		hitParticles.transform.position = hitPoint;
		
		// And play the particles.
//		hitParticles.Play();
		
		// If the current health is less than or equal to zero...
		if(currentHealth <= 0)
		{
			// ... the enemy is dead.
			Death ();
		}
	}

	void Death ()
	{
		// The enemy is dead.
		isDead = true;
		
		// Turn the collider into a trigger so shots can pass through it.
//		capsuleCollider.isTrigger = true;
//		
//		// Tell the animator that the enemy is dead.
//		anim.SetTrigger ("Dead");
//		
//		// Change the audio clip of the audio source to the death clip and play it (this will stop the hurt clip playing).
//		enemyAudio.clip = deathClip;
//		enemyAudio.Play ();
	}

}
