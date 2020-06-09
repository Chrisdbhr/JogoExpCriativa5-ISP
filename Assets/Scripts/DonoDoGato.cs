using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DonoDoGato : MonoBehaviour, IInteractable {
	[NonSerialized] private bool interacted;
	[SerializeField] private UnityEvent _deliveredCat;
	public GameObject gatoNoOmbro;
	
	public void OnInteract() {
		if (!this.gatoNoOmbro.activeInHierarchy) return;
		this._deliveredCat?.Invoke();
		this.interacted = true;
	}
}
