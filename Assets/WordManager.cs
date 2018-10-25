using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour {

	public List<Word> words;
	public StartCountdown time; 
	public ScoreManager Score;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private Word activeWord;
	//Limits words on screen to three.
	private int removeCounter = 3;
	//Counter to reset the removeCounter.
	private int addCounter = 0;

	public void AddWord ()
	{
		while (removeCounter > 0) {
			Word word = new Word (WordGenerator.GetRandomWord (), wordSpawner.SpawnWord ());
			words.Add (word);
			removeCounter--;
		}
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
			//Will add to word counter and allow generation of new word
			addCounter++;
			//This if statement is where slime 'kill count' will be kept as well.
			if (addCounter == 3) {
				removeCounter = 3;
				addCounter = 0;
				time.timeLeft = 8f ;
				ScoreManager.score  += 1;

			}
		}
	}

}
