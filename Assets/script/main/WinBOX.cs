using UnityEngine;
using System.Collections;

public class WinBOX : MonoBehaviour {
	public GameObject text;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionStay(Collision collision) {
		if(collision.collider.tag == "player"){	
			text.gameObject.SetActive(true);
		}
	}
}
