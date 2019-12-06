using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

    //public GameObject trigger;
    public AudioSource audioSource;
    public AudioClip audioClip;
	// Use this for initialization
	void Start () {
        audioSource.clip = audioClip;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
            audioSource.Play();
	}

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //trigger.SetActive(true); //maybe not necessary
            audioSource.Play();
        }
    }
}
