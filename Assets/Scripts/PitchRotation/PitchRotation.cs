using UnityEngine;
using System.Collections;

public class PitchRotation : MonoBehaviour {

	public float thrust;
	private Rigidbody rb;

    //These variables will push us through the possible states.
    private bool acceptUserInput = false;
    private bool pitchWindup = false;
    private bool ballInFlight = false;
    private bool pitchDone = false;
    private Vector3 initialRotation;
    private Quaternion intialRot;

    private PitchType pitch = new PitchType ();
	

	// Use this for initialization

	void Start () {
        //The rigid body is the ball;
        rb = GetComponent<Rigidbody> ();
        initialRotation = transform.localEulerAngles;
        

        intialRot = transform.rotation;
        


        //transform.Rotate(initialRotation);
        //rb.rotation.Set(0.0f, 0.0f, 90.0f, 0.0f);
        acceptUserInput = true;
    }


    // Update is called once per frame
    void Update() {

        //transform.Rotate(Vector3.up, ((360 * 5) * Time.deltaTime));
        //Are we at the state to accept user input
        if (acceptUserInput)
        {
            //In here we will start the pitch by pressing p
            if (Input.GetKey("p"))
            {
                acceptUserInput = false;
                pitchWindup = true;

            }

            if(Input.GetKey("down"))
            {
                //Slow time down
                Time.timeScale = Time.timeScale/1.1f;

            }

            if (Input.GetKey("up"))
            {
                //Slow time down
                Time.timeScale = Time.timeScale * 1.1f;

            }


            if (Input.GetKey("f"))
            {
                pitch.setPitchType("Fastball");

            }

            if (Input.GetKey("s"))
            {
                pitch.setPitchType("Slider");

            }

            if (Input.GetKey("r"))
            {
                
                float rndFloat = Random.Range(1.5f, 2.5F);

                int rndPitch = (int)rndFloat;


                switch (rndPitch)
                {
                    case 1: 
                            pitch.setPitchType("Fastball");
                        break;

                    case 2:
                            pitch.setPitchType("Slider");
                        break;

                }

                
            }


        }

        if (pitchWindup)
        {
            //Windup the pitch and let it go..
            //In here I will setup the pitch type and get ready to release
            pitchWindupRoutine();

            pitchWindup = false;
            ballInFlight = true;

        }


        if (ballInFlight)
        {
            //transform.Rotate(Vector3.up, 10 * Time.deltaTime);
            transform.Rotate(pitch.getBallRotation(), pitch.getRotationSpeed() * Time.deltaTime);
            print("ball in Flight");

            if(rb.position.z < -0.1f)
            {
                ballInFlight = false;
                pitchDone = true;
                

            }
          
            
        }

        if (pitchDone)
        {
            pitchDone = false;
            acceptUserInput = true;
            print("putting ball back");
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.position = new Vector3(-0.75f, 2.5f, 18.404f);
        
            transform.rotation  =  intialRot;
        }
    }


	void FixedUpdate()
	{
		

	}


    //These are the private helper functions to pass us through the states.

    
    private void pitchWindupRoutine()
    {

        //Position the ball
        rb.position.Set(0.75f, 2.3f, 18.404f);
        //Position the ball to initial rotation.

        if (pitch.getPitchType() == "Fastball")
        {
            transform.Rotate(new Vector3(0.0f, 0.0f, 90.0f));
            pitch = new Fastball();
        }

        else if (pitch.getPitchType() == "Slider")
        {
            transform.Rotate(new Vector3(90.0f, 0.0f, 0.0f));
            pitch = new Slider();

        }

        rb.AddForce(pitch.getPitchForce(), ForceMode.VelocityChange);


    }


    private void ballInFlightState()
    {
        


    }

    private void pitchDoneState()
    {



    }





}
