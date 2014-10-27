using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ParallaxMaterial : MonoBehaviour 
{
	// Transform representing the current 
	public Transform currentLocation;

	// Reference to the material object
	public Material  material;

	// Scrolling rates
	public float     rate;
	public float     rateInducedByTime;

	// The initial horizontal position
	private float    initialHorizontalPosition;

	// When the script starts, get the initial horizontal position
	void Awake ()
	{
		// Get the initial horizontal position
		initialHorizontalPosition = currentLocation.position.x;
	}

	void LateUpdate () 
	{
		// Get the horizontal difference between the camera and its starting point
		float distance = currentLocation.position.x - initialHorizontalPosition;

		// Compute the offset
		float offset = (distance / rate);

		// If we have offset induced by time, compute it
		if(rateInducedByTime > 0.0f)
			offset += Time.time / rateInducedByTime;

		// Set the texture offset
		Vector2 currentOffset = material.mainTextureOffset;
		currentOffset.x = offset;
		material.mainTextureOffset = currentOffset;
	}
}
