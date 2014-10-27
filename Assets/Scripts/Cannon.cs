using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour 
{
	// Muzzle transform
	public Transform   muzzleTransform;
	public Transform   cameraTransform;
	public GameObject  projectilePrefab;

	// Cannon rotation rate
	public float       rate = 30.0f;

	// Instantiated projectile
	private GameObject projectile;

	// Update is called once per frame
	void Update () 
	{
		// If we are to fire a projectile
		if(Input.GetKeyDown(KeyCode.Space) && projectile == null)
		{
			// Create the projectile at the position and orientation of the cannon muzzle
			projectile = Instantiate(projectilePrefab, muzzleTransform.position, muzzleTransform.rotation) as GameObject;

			// Add a force to propel the projectile
			projectile.rigidbody2D.AddRelativeForce(new Vector2(1.0f, 0.0f) * 300.0f);
			projectile.rigidbody2D.AddTorque(-200.0f);
		}

		// If escape is pressed, stop tracking the projectile and 
		else if(Input.GetKeyDown(KeyCode.Escape))
		{
			Destroy(projectile);
			projectile = null;

			// Focus on the cannon again
			Vector3 position = cameraTransform.position;
			position.x = 0.0f;
			position.y = 0.0f;
			cameraTransform.position = position;
		}

		// Cannon rotate logic
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Rotate(0.0f, 0.0f, Time.deltaTime * rate);
		} 
		
		else if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Rotate(0.0f, 0.0f, Time.deltaTime * -rate);
		}
	}
}
