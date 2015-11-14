using UnityEngine;
using System.Collections;

public class NaveController : MonoBehaviour {

	public GameObject nave;
	private bool landed;
	private Vector3 initialAcceleration, gravityVector, translation;
	private float gravity;

	void Start () {
		landed = false;
		gravity = 0.2f;
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
			translation = initialAcceleration + gravityVector * Time.fixedTime;
			nave.transform.Translate(translation);
		}
	}
}
