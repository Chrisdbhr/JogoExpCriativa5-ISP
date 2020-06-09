using System;
using UnityEngine;

public class DialogBox : MonoBehaviour {
	
	private void Awake() {
		this.gameObject.SetActive(false);
	}
	
	public void CaridadeAdd(int ammount) {
		if (!this.enabled) return;
		Player.Caridade += ammount;
		this.gameObject.SetActive(false);
		this.enabled = false;
	}
}