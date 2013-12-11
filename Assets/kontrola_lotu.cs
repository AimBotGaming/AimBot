using UnityEngine;
using System.Collections;

public class kontrola_lotu : MonoBehaviour {

	//public Vector3 predkosc_poczatkowa;
	public float wartosc_obrotu;
	public float czas_obrotu;
	public Quaternion max_obrot;
	private Quaternion miernikobrotu;
	private Quaternion aktobrot;
	private Quaternion nowyobrot;


	void Start () {
	}
	

	void Update () {
		aktobrot=gameObject.rigidbody.rotation;
		nowyobrot=aktobrot;
		if((Input.GetKey(KeyCode.LeftArrow))&&(-miernikobrotu.x<max_obrot.x)){
			nowyobrot.x=nowyobrot.x-wartosc_obrotu;
			miernikobrotu.x=miernikobrotu.x-wartosc_obrotu;
		}
		if(Input.GetKey(KeyCode.RightArrow)&&(miernikobrotu.x<max_obrot.x)){
			nowyobrot.x=nowyobrot.x+wartosc_obrotu;
			miernikobrotu.x=miernikobrotu.x+wartosc_obrotu;
		}
		if((Input.GetKey(KeyCode.DownArrow))&&(-miernikobrotu.y<max_obrot.y)){
			nowyobrot.y=nowyobrot.y-wartosc_obrotu;
			miernikobrotu.y=miernikobrotu.y-wartosc_obrotu;
		}
		if(Input.GetKey(KeyCode.UpArrow)&&(miernikobrotu.y<max_obrot.y)){
			nowyobrot.y=nowyobrot.y+wartosc_obrotu;
			miernikobrotu.y=miernikobrotu.y+wartosc_obrotu;
		}
		gameObject.rigidbody.rotation=Quaternion.Lerp(aktobrot,nowyobrot,Time.deltaTime*czas_obrotu);
	}
}
