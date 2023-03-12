using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
	public GameObject Sound1;

	public AudioSource playSound;

	void OnTriggerEnter(Collider other)
	{
		playSound.Play();

		Destroy(Sound1);
	}
}
