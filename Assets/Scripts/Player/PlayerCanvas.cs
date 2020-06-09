using UnityEngine;

public class PlayerCanvas : MonoBehaviour {
	[SerializeField] private Animator AnimInteractable;

	public void HasInteractable(bool value) {
		if(this.AnimInteractable)this.AnimInteractable.SetBool("hasInteractable", value);
	}
}
