using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.Label(new Rect(0,0,80,20), "Hello World");
		GUI.Box(new Rect(Screen.width / 2, Screen.height /2, 100, 50), "Hello World in a box");
	}

}
