using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {

	[SerializeField]
	private Gate _gate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "CubeBot" ||
						other.tag == "CubeMid" ||
						other.tag == "CubeTop")
						_gate.OpenGate ();
	}
}
