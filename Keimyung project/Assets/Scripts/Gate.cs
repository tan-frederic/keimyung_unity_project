using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {

	private bool _isOpen = false;
	[SerializeField]
	private float height;
	private Vector3 dest;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){
		if (_isOpen && this.transform.position != dest) {
			this.transform.position = Vector3.Lerp(this.transform.position, dest, Time.deltaTime);
		}
	}

	public void OpenGate()
	{
		_isOpen = true;
		dest = new Vector3(this.transform.position.x, this.transform.position.y - height, this.transform.position.z);
	}
}
