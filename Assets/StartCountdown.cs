using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCountdown : MonoBehaviour {
	public float timeLeft = 8f;
	public Health playerHealth;
	public Slider Timer;
	public void StartOver(){
		timeLeft = 8f;
	}
	void Update()
	{
		timeLeft -= Time.deltaTime;
		Timer.value = timeLeft;
		if(timeLeft <= 0)
		{
			playerHealth.TakeDamage(10);
			timeLeft += 8f;
		}
	
		
	}
	

}
