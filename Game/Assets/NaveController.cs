using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NaveController : MonoBehaviour {

	public GameObject nave;
	private bool landed;
	private Vector3 initialAcceleration, gravityVector, velocity, translation, acceleration, thrusterVector;
	public float gravity;
	public Text velocityText, accelText, positionText;

	void Start () {
		landed = false;
		gravityVector = Vector3.down * gravity;
		thrusterVector = Vector3.zero;
		initialAcceleration = Vector3.zero;
	}
	
	void Update () {
	
		if (nave.transform.position.y <= -12.0f) 
		{
			landed = true;
		}
		
		if ( Input.GetKey("space") )
		{
			thrusterVector = Vector3.up * 10.0f;
			Debug.Log ("going up");
		} else {
			thrusterVector = Vector3.zero;
		}
		
		if(!landed)
		{
			acceleration = gravityVector + thrusterVector;
			velocity = velocity + acceleration * Time.deltaTime;
			translation = velocity * Time.deltaTime;
			velocityText.text = velocity.y.ToString();
			accelText.text = Time.fixedTime.ToString();
			positionText.text = translation.y.ToString();
			nave.transform.Translate(translation);
		}
	}
}
