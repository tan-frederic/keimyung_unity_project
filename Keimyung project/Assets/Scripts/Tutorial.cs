using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

	[SerializeField]
	private GameObject _tutoPanel;
	[SerializeField]
	private UnityEngine.UI.Text _tutoText;
	[SerializeField]
	private string _tutoMessage;
	[SerializeField]
	private int _typeKey;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (_typeKey == 0 && Input.GetKeyDown (KeyCode.Keypad1) ||
		    _typeKey == 1 && Input.GetKeyDown (KeyCode.Keypad2) ||
            _typeKey == 2 && Input.GetKeyDown(KeyCode.Keypad3)) {
			Time.timeScale = 1;
			_tutoPanel.SetActive (false);
				}
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "CubeBot" ||
						other.tag == "CubeMid" ||
						other.tag == "CubeTop")
						Time.timeScale = 0;
		_tutoText.text = _tutoMessage;
		_tutoPanel.SetActive (true);
	}
}
