using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomUnityEvents : MonoBehaviour {

	public UnityEvent onAwake;
	public UnityEvent onEnable;
	public UnityEvent onDisable;

	private void Awake() {
		this.onAwake?.Invoke();
	}

	private void OnEnable() {
		
		this.onEnable?.Invoke();
	}

	private void OnDisable() {
		this.onDisable?.Invoke();
		
	}
}
