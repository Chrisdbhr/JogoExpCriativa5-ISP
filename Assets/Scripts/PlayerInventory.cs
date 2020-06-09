using UnityEngine;

public class PlayerInventory : MonoBehaviour {

	public GameObject HudItemLanche;
	
	public void ItemLanche(bool ativar) {
		this.HudItemLanche.SetActive(ativar);
	}
}