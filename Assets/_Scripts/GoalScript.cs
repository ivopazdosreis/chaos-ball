using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private bool solved = false;

	void OnTriggerEnter(Collider other) { 
		if(other.tag == tag) {
			solved = true;
			other.GetComponent<Rigidbody>().isKinematic = true;
		}
	}

	public bool IsSolved() { 
		return solved;
	}

}
