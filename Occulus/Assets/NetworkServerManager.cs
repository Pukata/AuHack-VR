using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkServerManager : MonoBehaviour {
	// Use this for initialization
	void Start () {
        NetworkServer.Listen(4444);	
	}
}
