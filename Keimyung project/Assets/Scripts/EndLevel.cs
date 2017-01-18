using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {

	[SerializeField]
	private GameManager _end;


	void OnTriggerEnter(Collider other) {
		if (other.tag == "CubeBot" ||
						other.tag == "CubeMid" ||
						other.tag == "CubeTop")
						_end.EndLevel ();
	}
}
