using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour 
{
	// Update is called once per frame
	void LateUpdate () 
	{
		Vector3 position = Camera.main.transform.position;
		position.x = transform.position.x;
		Camera.main.transform.position = position;
	}
}
