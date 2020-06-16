
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BoxCollider2D))]
public class ShowTextInteractable : MonoBehaviour, IInteractable {

	[SerializeField] private DialogBox _dialogBox;
	
	
	[SerializeField] private UnityEvent OnShow;
	[SerializeField] private UnityEvent OnHide;
	
	
	
	
	public void OnInteract() {
		if (!this._dialogBox.enabled) return;
		this._dialogBox.gameObject.SetActive(true);
		this.OnShow?.Invoke();
	}
	private void OnTriggerEnter2D(Collider2D other) {
		if (!this._dialogBox.enabled) return;
		this._dialogBox.gameObject.SetActive(true);
		this.OnShow?.Invoke();
	}
	
	private void OnTriggerExit2D(Collider2D other) {
		if (!this._dialogBox.enabled) return;
		this._dialogBox.gameObject.SetActive(false);
		this.OnHide?.Invoke();
	}
	
}
