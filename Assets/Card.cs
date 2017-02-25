using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

	private Suits suit;
	private Numbers number;

	public Suits Suit {
		get {
			return suit;
		}
		set {
			suit = value;
		}
	}

	public Numbers Number {
		get {
			return number;
		}
		set {
			number = value;
		}
	}
}
