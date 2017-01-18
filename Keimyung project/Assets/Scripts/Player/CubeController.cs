using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {
	
	private float _distToGround;
	private Vector3 _heightJump;
	private Rigidbody _rigidboy;
	
	private bool _onJump = false;
	private bool _onCube = true;

	[SerializeField]
	private float _jumpValue = 7.0f;

	public bool isJumping
	{
		get { return _onJump; }
	}

	public bool isOnCube
	{
		get { return _onCube; }
		set { _onCube = value; }
	}

	void Start () {
		_distToGround = collider.bounds.extents.y;
		_rigidboy = GetComponent<Rigidbody>();
		collider.material = null;
	}

	void Update () {

	}

	void FixedUpdate()
	{
		if (isOnTheFloor() == false) {
			_onJump = false;
		}
	}

	public void jump()
	{
		if (isOnTheFloor ()) {
			_rigidboy.velocity = Vector3.zero;
			_rigidboy.velocity = new Vector3(0, _jumpValue, 0);
			_onJump = true;
		}
	}

	private bool isOnTheFloor()
	{
		return Physics.Raycast(transform.position, -Vector3.up, _distToGround + 0.1f);
	}

	void OnCollisionEnter(Collision collision) {

		if (collision.gameObject.tag == "Obstacle") {
			_rigidboy.constraints = ~RigidbodyConstraints.FreezeAll;
			this.transform.parent = null;
		}
		if ((collision.gameObject.tag == "CubeBot" && tag == "CubeMid") ||
			(collision.gameObject.tag == "CubeMid" && tag == "CubeTop")) {
			_onCube = true;
		}
	}
}
