using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public static MusicManager _instance = null;
    [SerializeField]
    private AudioClip[] _audio;
    private AudioSource _audioSource;
    private int _type = -1;

    void Awake()
    {
        if (!_instance)
        {
            _instance = this;
            _audioSource = GetComponent<AudioSource>();
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

	// Update is called once per frame
	void Update () {
	
	}

    public void PlayMusic(int type)
    {
        if (type != _type)
        {
            _type = type;
            _audioSource.clip = _audio[type];
            _audioSource.loop = true;
            _audioSource.Play();
        }
    }
}
