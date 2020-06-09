using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GatoEvent : MonoBehaviour, IInteractable {
	public bool gatoPego = false;
	public UnityEvent gatoPegoEvento;

	private void OnTriggerEnter2D(Collider2D other) {
		this.OnInteract();
	}

	public void OnInteract() {
		this.PegarGato();
	}

	private void PegarGato() {
		if (this.gatoPego) return;
		this.gatoPegoEvento?.Invoke();
		this.gatoPego = true;
	}
}
