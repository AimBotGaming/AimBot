using UnityEngine;
using System.Collections;

[ExecuteInEditMode]

public class CameraTTPFollow : MonoBehaviour {
    
    private Transform _target;
    private Transform _maincamera;

    public float _distZ = 4.0f;
    public float _distY = 1.5f;

	void Start () {
        _target = transform;
        _maincamera = Camera.main.transform;
		
	}
	
	void Update () {
        _maincamera.position = _target.position + new Vector3(0, _distY, -_distZ);
        _maincamera.LookAt(_target);
	}
}
