using UnityEngine;
using System.Collections;

public class SimpleDriver : MonoBehaviour 
{
	// params
	public float rate = 1.0f;
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 position = transform.position;
		position.x += rate * Time.deltaTime;
		transform.position = position;
	}
}
