using System;
using UnityEngine;

public class Player : MonoBehaviour {
	public static int Caridade = 0;

	[SerializeField] private float _playerWalkSpeed = 8f;
	[SerializeField] private float _interactionRadius = 2f;
	[SerializeField] private LayerMask _interactionLayerMask = 1;
	[SerializeField] private PlayerCanvas _playerCanvas;
	[SerializeField] private IInteractable _currentInteractable;
	[SerializeField] private Transform _playerSprite;
	
	[NonSerialized] private Transform _transform;
	[NonSerialized] private Rigidbody2D _rb;

	[SerializeField] private Animator anim;
	
	private void Awake() {
		this._transform = this.transform;
		this._rb = this.GetComponent<Rigidbody2D>();
	}

	private void Update() {
		float velX = this._rb.velocity.x;
		this.anim.SetBool("walk", velX < -1 || velX > 1);
		
		this._playerSprite.localScale = new Vector3(this.GetFacingDirection(), this._playerSprite.localScale.y, 1f);
	}

	private void FixedUpdate() {
		this._rb.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * this._playerWalkSpeed,0f, 0f);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		var inter = other.GetComponent<IInteractable>();
		inter?.OnInteract();
	}

	private float GetFacingDirection() {
		if (this._rb.velocity.x > 1f) return 1f;
		if (this._rb.velocity.x < -1f) return -1f;
		return this._playerSprite.localScale.x;
	}
	
	public void CaridadeAdd(int ammount) {
		Player.Caridade += ammount;
	}
}
