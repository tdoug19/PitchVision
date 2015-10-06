using UnityEngine;
using System.Collections;

public class TestScripts : MonoBehaviour {

    private Rigidbody rb;

    
    private Vector3 initialRotation;
    private Quaternion intialRot;

    private PitchType pitch = new PitchType();


    // Use this for initialization

    void Start()
    {
        //The rigid body is the ball;
        rb = GetComponent<Rigidbody>();
        
        //  Test the Fastball
        pitch = new Fastball();
        pitch.setRotationSpeed(40.0f * 360.0f);
        transform.Rotate(new Vector3(0.0f, 0.0f, 90.0f));
        



       // pitch = new Slider();
        //pitch.setRotationSpeed(5.0f * 360.0f);
        //transform.Rotate(new Vector3(95.0f, 0.0f, 0.0f));


    }
	
	// Update is called once per frame
	void Update () {


        transform.Rotate(pitch.getBallRotation(), pitch.getRotationSpeed() * Time.deltaTime);

        
    }
}
