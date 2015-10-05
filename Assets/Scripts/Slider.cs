using UnityEngine;
using System.Collections;

public class Slider : PitchType {
	
	public Slider(){


        setPitchForce(new Vector3(1.0f, 1.5f, -30.4688f));
        setRotationSpeed(5.0f * 360.0f);  //This is 1 Rev * 30  If I multiply by time delta it will be This many Revs/sec.
        setBallRotation(new Vector3(0.0f, 1.0f, 0.0f));


    }
	
	
}
