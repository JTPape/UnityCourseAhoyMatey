using UnityEngine;
<<<<<<< HEAD
using UnityEngine.Networking;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour
=======
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
>>>>>>> 7c84aba815ef2d14fa84c79ac62d3819ade5336f
{

	private Vector3 inputValue;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
<<<<<<< HEAD
		if (!isLocalPlayer) {
			return; 
		}
=======
>>>>>>> 7c84aba815ef2d14fa84c79ac62d3819ade5336f

		inputValue.x = CrossPlatformInputManager.GetAxis ("Horizontal");
		inputValue.z = CrossPlatformInputManager.GetAxis ("Vertical");
		inputValue.y = 0f;

		transform.Translate (inputValue);
	}


}
