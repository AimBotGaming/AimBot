using UnityEngine;
using System.Collections;

public class bron : MonoBehaviour {

	public GameObject prefab_pocisku;
	public Transform koniec_lufy;
	public GameObject os_obrotu;
	public float szybksc_celowania;

	private bool strzelil;


	void Start(){
		strzelil=false;
	}

	void FixedUpdate () {
		if((Input.GetButtonDown("Fire1"))&&(strzelil==false)){
			Instantiate(prefab_pocisku, koniec_lufy.position, koniec_lufy.rotation);
			strzelil=true;
		}
		if((Input.GetKey(KeyCode.LeftArrow))&&(strzelil==false)){
			gameObject.transform.RotateAround(os_obrotu.transform.position,Vector3.down,szybksc_celowania);
		}
		if((Input.GetKey(KeyCode.RightArrow))&&(strzelil==false)){
			gameObject.transform.RotateAround(os_obrotu.transform.position,Vector3.up,szybksc_celowania);
		}
		if((Input.GetKey(KeyCode.UpArrow))&&(strzelil==false)){
			gameObject.transform.RotateAround(os_obrotu.transform.position,Vector3.left,szybksc_celowania);
		}
		if((Input.GetKey(KeyCode.DownArrow))&&(strzelil==false)){
			gameObject.transform.RotateAround(os_obrotu.transform.position,Vector3.right,szybksc_celowania);
		}

	}
}