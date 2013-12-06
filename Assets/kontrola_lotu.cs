using UnityEngine;
using System.Collections;

public class kontrola_lotu : MonoBehaviour {

	public float predkosc_poczatkowa;

	void Start () {
		gameObject.rigidbody.AddForce(Vector3.forward * predkosc_poczatkowa);
	}
	

	void FixedUpdate () {

	}
}
