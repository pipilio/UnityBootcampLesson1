using UnityEngine;
using System.Collections;

public class NaveController : MonoBehaviour {

	public GameObject nave;
	private bool landed;
	private Vector3 initialAcceleration, gravityVector, velocity, translation, acceleration;
	public float gravity;

	void Start () {
		landed = false;
		gravityVector = Vector3.down * gravity;
		initialAcceleration = Vector3.zero;
	}
	
	void Update () {
	
		if (nave.transform.position.y <= -12.0f) 
		{
			landed = true;
		}
		
		if(!landed)
		{
			acceleration = gravityVector;
			velocity = velocity + acceleration * Time.deltaTime;
			translation = translation + velocity * Time.deltaTime;
			nave.transform.Translate(translation);
		}
	}
}
