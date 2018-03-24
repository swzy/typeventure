using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountdown : MonoBehaviour {
	float timeLeft = 5f;
	public Health playerHealth;
	public Slider Timer;
	void StartOver(){
		timeLeft = 5f;
	}
	void Update()
	{
		timeLeft -= Time.deltaTime;
		Timer.value = timeLeft;
		if(timeLeft <= 0)
		{
			playerHealth.TakeDamage(10);
			timeLeft += 5f;
		}
	
		
	}
	

}
