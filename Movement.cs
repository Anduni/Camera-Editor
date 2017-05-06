using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]

public class Movement : MonoBehaviour {
	
	public float speed;
	public float smooth;
	float h;
	float v;
	float sh;
	float sv;

	void Update (){
		h = Input.GetAxis ("Horizontal") * speed;
		v = Input.GetAxis ("Vertical") * speed;
		SmoothMovement ();
	}

	void FixedUpdate () {
		transform.position = new Vector3 (transform.position.x + sh, 
			transform.position.y, transform.position.z + sv);
	}

	void SmoothMovement() {
		sh = Mathf.Lerp (sh, h, smooth);
		sv = Mathf.Lerp (sv, v, smooth);
	}
}