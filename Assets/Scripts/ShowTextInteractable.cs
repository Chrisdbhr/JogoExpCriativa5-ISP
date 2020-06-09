
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ShowTextInteractable : MonoBehaviour, IInteractable {

	[SerializeField] private DialogBox _dialogBox;
	
	public void OnInteract() {
		if (!this._dialogBox.enabled) return;
		this._dialogBox.gameObject.SetActive(true);
	}
	private void OnTriggerEnter2D(Collider2D other) {
		if (!this._dialogBox.enabled) return;
		this._dialogBox.gameObject.SetActive(true);
	}
	
	private void OnTriggerExit2D(Collider2D other) {
		if (!this._dialogBox.enabled) return;
		this._dialogBox.gameObject.SetActive(false);
	}
	
}
