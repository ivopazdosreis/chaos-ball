using UnityEngine;
using System.Collections;

public class VelocityScript : MonoBehaviour {

	public float max = 50; // to add in the Class, before Start()

	// Use this for initialization
	void Start ()
    {
		GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0,max),0, Random.Range(0,max)); // to add in Start()
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

	private bool solved = false;
	void OnTriggerEnter(Collider other)
    { 
		if(other.tag == tag)
        {
			solved = true;
			other.GetComponent<Rigidbody>().isKinematic = true;
		}
    }

	public bool IsSolved()
    { 
        return solved;
	}
}

