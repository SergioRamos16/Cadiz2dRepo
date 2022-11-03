using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
	private string Tag = "Player";

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			OnPlayerEnter();
		}
	}

	public virtual void OnPlayerEnter()
	{
		Debug.Log("Entro el player");
	}
}