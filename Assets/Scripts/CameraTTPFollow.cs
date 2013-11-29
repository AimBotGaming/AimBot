using UnityEngine;
using System.Collections;

[ExecuteInEditMode]

public class CameraTTPFollow : MonoBehaviour {
    
    private Transform _target;
    private Transform _camera;

    public float _disZ = 4.0f;
    public float _disY = 1.5f;

	void Start () {
        _target = transform;
        _camera = Camera.main.transform;
	}
	
	void Update () {
        _camera.position = _target.position + new Vector3(0, _disY, -_disZ);
        _camera.LookAt(_target);
	}
}
