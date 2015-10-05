using UnityEngine;
using System.Collections;

public class Fastball : PitchType {

    public Fastball(){

        setPitchForce(new Vector3(0.7f, 0.1f, -42.4688f));
        setRotationSpeed(30.0f * 360.0f);  //This is 1 Rev * 30  If I multiply by time delta it will be This many Revs/sec.
        setBallRotation(new Vector3(0.0f, -1.0f, 0.0f));
	}
}
