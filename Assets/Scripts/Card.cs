using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
	private GameManager gm;
	public bool hasBeenPlayed;
	public int handIndex;


	private void Start()
	{
		gm = FindObjectOfType<GameManager>();
	}
	private void OnMouseDown()
	{

		if (hasBeenPlayed == false)
		{
			print(gameObject.name);
			transform.position += Vector3.up * 2;
			hasBeenPlayed = true;
			gm.availableCardslots[handIndex] = true;

		}


	}
}

	




