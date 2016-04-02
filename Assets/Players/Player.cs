using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour
{

	private Vector3 inputValue;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!isLocalPlayer) {
			return; 
		}

		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");
		inputValue.y = 0f;

		transform.Translate (inputValue);
	}


}
