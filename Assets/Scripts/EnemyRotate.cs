using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour {

	public GameObject pivot;
	public float rotateSpeed = 50f;
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(pivot.transform.position, Vector3.forward, rotateSpeed * Time.deltaTime);
	}
}
