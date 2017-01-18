using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private CubeController[] _rigidbody;
	[SerializeField]
	private GameObject[] _stars;
	[SerializeField]
	private float _speed = 5;

	private int _nbrStar = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + _speed, transform.position.y, transform.position.z), Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Keypad1)) {
			_rigidbody[0].jump();
			if (_rigidbody[1].isOnCube == true)
			{
				_rigidbody[1].jump();
				if (_rigidbody[2].isOnCube == true)
				{
					_rigidbody[2].jump();
				}
			}

		}
		if (Input.GetKeyDown (KeyCode.Keypad2)) {
			_rigidbody[1].jump();
			_rigidbody[1].isOnCube = false;
			if (_rigidbody[2].isOnCube == true)
			{
				_rigidbody[2].jump();
			}
		}
		if (Input.GetKeyDown (KeyCode.Keypad3)) {
			for (int i = 2; i < _rigidbody.Length; ++i)
			{
				_rigidbody[i].jump();
				_rigidbody[i].isOnCube = false;
			}
		}
	}

	public void addStar(int pos)
	{
		_stars [pos].gameObject.SetActive (true);
		_stars[pos].gameObject.GetComponentInChildren<Animation>().Play();
		++_nbrStar;
	}
}
