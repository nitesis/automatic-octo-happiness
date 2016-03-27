using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(5, 5, 30) * Time.deltaTime);
	}
}
