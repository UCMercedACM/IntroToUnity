using UnityEngine;
using System.Collections;

public class TestTrigger : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D c)
	{
		// Get the projectile from the game object
		Projectile projectile = c.GetComponent<Projectile>();

		// If it was a projectile that entered
		if(projectile != null)
		{	
			Debug.Log("Projectile Entered: " + c);
		}
	}

	void OnTriggerExit2D(Collider2D c)
	{
		// Get the projectile from the game object
		Projectile projectile = c.GetComponent<Projectile>();
		
		// If it was a projectile that entered
		if(projectile != null)
		{	
			Debug.Log("Projectile Exited: " + c);
		}
	}
}
