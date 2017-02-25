using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour {
	[SerializeField]
	private Stack<Card> myStack = new Stack<Card>();

	[SerializeField]
	private Text stackText;

	[SerializeField]
	private Button logButton;

	[SerializeField]
	private Button shuffleButton;

	private string[] myNumbers;
	private string[] mySuits;


	// Use this for initialization
	void Start () {
		GetNumbersAndSuits ();
		ConfingButtons ();
		FillStack ();

	}

	void FillStack () {
		for (int i = 0; i < mySuits.Length; i++) 
		{
			for (int j = 0; j < myNumbers.Length; j++) 
			{
				Card tempCard = new Card ();
				tempCard.Suit = (Suits)System.Enum.Parse(typeof(Suits),mySuits[i]) ;
				tempCard.Number = (Numbers)System.Enum.Parse(typeof(Numbers),  myNumbers[j] ) ;
				myStack.Push (tempCard);
			}
		}
	}

	void GetNumbersAndSuits ()
	{
		myNumbers = System.Enum.GetNames(typeof(Numbers));
		mySuits = System.Enum.GetNames (typeof(Suits));
	}

	void ConfingButtons ()
	{
		logButton.onClick.AddListener (LogFirstCard);
		shuffleButton.onClick.AddListener (ShuffleStack);
	}

	// Update is called once per frame
	public void ShuffleStack ()
	{
		myStack = myStack.Shuffle ();
	}

	public void LogFirstCard ()
	{
		string message = string.Format ("The card is {0} of {1}", myStack.Peek ().Number, myStack.Peek ().Suit); 
		stackText.text = message;
	}

}
