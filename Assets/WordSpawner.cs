using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;
	public Transform wordCanvas;
	private int i = 0;
	private Vector3 RealPosition;

	public WordDisplay SpawnWord ()
	{
		Vector3 Position1 = new Vector3(11.0f, 1.0f);
		Vector3 Position2 = new Vector3(13.0f, 4.5f);
		Vector3 Position3 = new Vector3(16.0f, 4.0f);

		i++;
		if (i == 1) {
			RealPosition = Position1;
		} else if (i == 2) {
			RealPosition = Position2;
		} else if (i == 3) {
			RealPosition = Position3;
			i = 0;
		}
			
		GameObject wordObj = Instantiate(wordPrefab, RealPosition, Quaternion.identity, wordCanvas);
		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

		return wordDisplay;
	}

}
