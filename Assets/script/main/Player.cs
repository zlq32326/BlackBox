using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//public GameObject text;
	// Use this for initialization
	void Awake(){
		Screen.SetResolution (510, 729, false);
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	//void OnCollisionStay(Collision collision) {
	//	if(collision.collider.name == "RED"){	
	//		text.gameObject.SetActive(true);
	//	}
	//}

}
