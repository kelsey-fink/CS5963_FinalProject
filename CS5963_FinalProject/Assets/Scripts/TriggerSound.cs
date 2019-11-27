using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

    public GameObject trigger;
    public AudioSource audioClip;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trigger.SetActive(true); //maybe not necessary
            audioClip.Play();
        }
    }
}
