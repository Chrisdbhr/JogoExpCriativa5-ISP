using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
		var p = other.collider.GetComponent<Player>();
		if (p == null) return;
		SceneManager.LoadSceneAsync("Result", LoadSceneMode.Single);
	} 
}
