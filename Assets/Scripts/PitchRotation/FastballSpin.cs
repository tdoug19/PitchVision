using UnityEngine;
using System.Collections;

public class FastballSpin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        transform.Rotate(Vector3.down, ((180) * Time.deltaTime));

    }
}
