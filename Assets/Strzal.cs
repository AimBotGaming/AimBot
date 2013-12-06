using UnityEngine;
using System.Collections;

public class Strzal : MonoBehaviour {

	public GameObject prefab_pocisku;
	public Transform koniec_lufy;

	void Update () {
		if(Input.GetButtonDown("Fire1"))Instantiate(prefab_pocisku, koniec_lufy.position, koniec_lufy.rotation);
	}
}