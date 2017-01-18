using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {

	[SerializeField]
	private PlayerController _player;
	[SerializeField]
	private int _pos = 0;
    private AudioSource _audio;

	// Use this for initialization
	void Start () {
	
	}

    void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
	
    void DestroyObj()
    {

    }

	void OnTriggerEnter(Collider other) {
		if (other.tag == "CubeBot" ||
						other.tag == "CubeMid" ||
						other.tag == "CubeTop")
			_player.addStar (Mathf.Clamp(_pos, 0, 2));
        _audio.Play();
        Invoke("DestroyObj", _audio.clip.length);
        MeshRenderer[] render = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer rend in render)
        {
            rend.enabled = false;
        }
//			Destroy(this.transform.parent.gameObject);
	}
}
