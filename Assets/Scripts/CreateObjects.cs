using UnityEngine;
using System.Collections;

public class CreateObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
        makeCapsules();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void makeCapsules()
    {
        for (int h = 0; h < 10; h++)
        {

        for (int i = 0; i < 10; i++)
        {
            GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            capsule.transform.position = new Vector3(i * 1.0f, i * 0.0f, h * 1.0f);
        }
    }

    }
}
