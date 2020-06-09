using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour {

    public float TimeToDestroy = 2f;
    
    void OnEnable() {
        Destroy(this.gameObject, this.TimeToDestroy);
    }

}
