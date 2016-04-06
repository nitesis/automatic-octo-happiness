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
				capsule.transform.position = new Vector3(Random.value * 100.0f, 40.0f, Random.value * (-20.0f));
//			capsule.transform.position = new Vector3(100.0f * Random.value, 100.0f * Random.value, 100.0f * Random.value);
//			transform.localScale += new Vector3(10.0f, 10.0f, 10.0f);
//				Component rotate = gameObject.AddComponent("Rotate") as Component;
				capsule.AddComponent<Rotate>();
//				capsule.AddComponent<new Color(Random.value *12, i, h )>();
		}
    }

    }
}
