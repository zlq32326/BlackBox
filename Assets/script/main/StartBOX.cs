using UnityEngine;
using System.Collections;

public class StartBOX : MonoBehaviour {

	
	public GameObject text;
	// Use this for initialization
	void Start () {
	
	}
	public GameObject Player;
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1")){  
				
			Vector3 a = Camera.main.ScreenToWorldPoint(Input.mousePosition); 

			if(a.y>4.5){
				Player.transform.position = new Vector3(a.x,a.y,0f);

				if(text.gameObject.activeSelf == true){
					text.gameObject.SetActive(false);
				}
			}				
		}  
	
	}
}
