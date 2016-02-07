using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	private Transform _target;
	public Transform Target {
		get { return _target; }
		set { _target = value; }
	}
	public float speed;

	// Use this for initialization
	void Update() {
		float step = speed * Time.deltaTime;

		if (this.Target != null) {
			transform.position = Vector3.MoveTowards (transform.position, this.Target.position, step);
		} else {
			Debug.Log("this.Target is null " + this.Target);

		}
	}
}
