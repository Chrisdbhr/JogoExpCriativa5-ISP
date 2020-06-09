using System;
using UnityEngine;

public class LevelManager : MonoBehaviour {
	#region <<---------- Singleton ---------->>
	public static LevelManager get {
		get {
			if (_instance == null) {
				_instance = FindObjectOfType<LevelManager>();
			}
			return _instance;
		}
	}

	private static LevelManager _instance;
	#endregion <<---------- Singleton ---------->>

	public Vector2 LayerBoundsX = new Vector2(1, 12);

	#if UNITY_EDITOR
	private const float DEBUG_LINE_SIZE = 10f;
	private void OnDrawGizmos() {
		Gizmos.color = Color.blue;
		Gizmos.DrawLine(new Vector3(this.LayerBoundsX.x, DEBUG_LINE_SIZE), new Vector3(this.LayerBoundsX.x, -DEBUG_LINE_SIZE));
		Gizmos.DrawLine(new Vector3(this.LayerBoundsX.y, DEBUG_LINE_SIZE), new Vector3(this.LayerBoundsX.y, -DEBUG_LINE_SIZE));
	}
	#endif
}
