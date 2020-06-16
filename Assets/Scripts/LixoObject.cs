using System;
using UnityEngine;

public class LixoObject : MonoBehaviour {
	
	[SerializeField]private LevelManager _levelManager;
	[SerializeField] private AudioSource _collectAudioSource;


	[NonSerialized] private bool _isColliding;
	
	
	
	
	public void OnInteract() {
		this._levelManager.LixoColetado();
		this.gameObject.SetActive(false);
		this._collectAudioSource.Play();
	}

	private void Update() {
		if (this._isColliding && Input.GetButton("Interact")) {
			this.OnInteract();
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.GetComponent<Player>() == null) return;
		this._isColliding = true;
	}
	
	private void OnTriggerExit2D(Collider2D other) {
		if (other.GetComponent<Player>() == null) return;
		this._isColliding = false;
	}

}
