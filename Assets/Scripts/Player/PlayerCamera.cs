using System;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
	[SerializeField] private Vector3 _followOffset;
	[SerializeField] private Transform _followTarget;
	
	
	

	private void Update() {
		var targetPos = this._followTarget.position + this._followOffset;
		var levelBounds = LevelManager.get.LayerBoundsX;
		targetPos.x = Mathf.Clamp(targetPos.x, levelBounds.x, levelBounds.y);
		this.transform.position = targetPos;
	}
}
