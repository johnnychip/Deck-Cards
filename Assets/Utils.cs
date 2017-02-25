using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{

	public static Stack<Card> Shuffle<Card> (this Stack<Card> cards)
	{
		int n = cards.Count;
		Card[] arrayMyStack = cards.ToArray ();

		while (n > 1) {
			n--;
			int k = Random.Range (0, n + 1);
			Card temp = arrayMyStack [k];
			arrayMyStack [k] = arrayMyStack [n];
			arrayMyStack [n] = temp;
		}

		Stack<Card> tempStack = new Stack<Card> ();

		for (int i = 0; i < cards.Count; i++)
			tempStack.Push(arrayMyStack[i]);
			
		return tempStack;
	}

}
