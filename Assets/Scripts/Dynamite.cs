using UnityEngine;
using System.Collections;

public class Dynamite : MonoBehaviour 
{
	public GameObject explosionPrefab;

	private static int explosionTrigger = Animator.StringToHash("Explode");
	private static int killState        = Animator.StringToHash("Base.Kill");
	private GameObject explosion;

	void OnTriggerEnter2D(Collider2D c)
	{
		// Ignore if already exploding
		if(explosion != null)
			return;

		// Get the projectile from the game object
		Projectile projectile = c.GetComponent<Projectile>();
		
		// If it was a projectile that entered
		if(projectile != null)
		{	
			Debug.Log("Projectile Entered: " + c);

			explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
			explosion.transform.parent = transform;
			renderer.enabled = false;
			explosion.GetComponent<Animator>().SetTrigger(explosionTrigger);
		}
	}

	void Update()
	{
		// If we are displaying the explosion and it transitions back to idle, kill it
		if(explosion != null)
		{
			if(explosion.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).nameHash == killState)
			{
				Debug.Log("Destroy");
				Destroy(explosion);
			}
		}
	}
}
