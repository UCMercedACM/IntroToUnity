using UnityEngine;
using System.Collections;

public class TestTrigger : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D c)
	{
		Debug.Log("Enter: " + c);
	}

	void OnTriggerExit2D(Collider2D c)
	{
		Debug.Log("Exit: " + c);
	}
}
