using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ResultController : MonoBehaviour {
	
	public UnityEvent ResultadoRuim;
	public UnityEvent ResultadoQuase;
	public UnityEvent ResultadoBom;
	
	
	private void Start() {

		int caridade = Player.Caridade;

		if (caridade <= 0) {
			this.ResultadoRuim?.Invoke();
		}else if (caridade == 1) {
			this.ResultadoQuase?.Invoke();
		}
		else {
			this.ResultadoBom?.Invoke();
		}
	}


	public void RestartGame() {
		SceneManager.LoadSceneAsync("Main", LoadSceneMode.Single);
		Player.Caridade = 0;
	}

	public void GoToMenu() {
		SceneManager.LoadSceneAsync("Title", LoadSceneMode.Single);
		Player.Caridade = 0;
	}
	
}
