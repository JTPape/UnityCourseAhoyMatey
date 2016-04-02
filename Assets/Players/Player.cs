using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour
{

	public float moveScalar = 0.3f;
	private Vector3 inputValue, rotateValue;

	public override void OnStartLocalPlayer ()
	{
		base.OnStartLocalPlayer ();
		GetComponentInChildren <Camera> ().enabled = true;
		GetComponentInChildren <AudioListener> ().enabled = true;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isLocalPlayer) {
			return; 
		}



		inputValue.x = 0f;
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical") * moveScalar;
		inputValue.y = 0f;

		rotateValue.x = 0f;
		rotateValue.y = CrossPlatformInputManager.GetAxis ("Horizontal");
		rotateValue.z = 0f;

		transform.Translate (inputValue);
		transform.Rotate (rotateValue);
	}


}
