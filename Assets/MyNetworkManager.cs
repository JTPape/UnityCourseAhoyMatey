﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void MyStartHost ()
	{
		Debug.Log ("" + Time.timeSinceLevelLoad + " Host Starting...");
		StartHost ();
	}


	public override void OnServerError (NetworkConnection conn, int errorCode)
	{
		Debug.Log ("Server Error: " + errorCode);
		base.OnServerError (conn, errorCode);
	}

	public override void OnStartHost ()
	{
		
		Debug.Log ("" + Time.timeSinceLevelLoad + " Host [" + singleton.networkAddress + "] [" + Network.player.ipAddress + "] Started Successfully");
	}

	public override void OnStartClient (NetworkClient myClient)
	{
		Debug.Log ("" + Time.timeSinceLevelLoad + " Client " + myClient + " requested start");
	}

	public override void OnClientConnect (NetworkConnection conn)
	{

		Debug.Log ("" + Time.timeSinceLevelLoad + " Client connected to " + conn.address);
		base.OnClientConnect (conn);
	}
}
