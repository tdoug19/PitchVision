using UnityEngine;
using System.Collections;
using System;

public class PitchType  {

	protected Vector3 pitchForce;
	protected float rotationSpeed;
	Vector3 ballRotation = new Vector3 (0.0f, 0.0f, 0.0f);
    private String pitchType;

	//public PitchType(){
	//	pitchForce = new Vector3 (0.0f, 0.0f, 0.0f);

	//}



	//public PitchType(Vector3 pitchForce)
//	{
		//is.pitchForce = pitchForce;
//	}

    public void setPitchType(String pitchType)
    {
        this.pitchType = pitchType;
    }

    public String getPitchType()
    {
        return pitchType;
    }

	public void setPitchForce(Vector3 pitchForce)
	{
		this.pitchForce = pitchForce;
	}

	public void setRotationSpeed (float rotationSpeed)
	{
		this.rotationSpeed = rotationSpeed;
	}

	public void setBallRotation( Vector3 ballRoataion)
	{
		this.ballRotation = ballRoataion;
	}

	public Vector3 getPitchForce()
	{
		return pitchForce;
	}

	public float getRotationSpeed()
	{
		return rotationSpeed;
	}

	public Vector3 getBallRotation()
	{
		return ballRotation;
	}

}
