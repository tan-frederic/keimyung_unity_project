using UnityEngine;
using System.Collections;

public class GameStatut : MonoBehaviour {

	[SerializeField]
	private GameManager _gm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "CubeBot" ||
			other.tag == "CubeMid" ||
			other.tag == "CubeTop") {
			_gm.GameOver();
		}
	}
}
