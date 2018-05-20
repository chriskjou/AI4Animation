using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retargeter : MonoBehaviour {

    public GameObject source;
    public Avatar destinationAvatar;

    private HumanPoseHandler sourceHandler;
    private HumanPoseHandler destinationHandler;

    private HumanPose humanPose;

	// Use this for initialization
	void Start () {
        humanPose = new HumanPose();
        sourceHandler = new HumanPoseHandler(source.GetComponent<Animator>().avatar, source.transform);
        destinationHandler = new HumanPoseHandler(destinationAvatar, transform);
	}
	
	// Update is called once per frame
	void Update () {
        sourceHandler.GetHumanPose(ref humanPose);
        destinationHandler.SetHumanPose(ref humanPose);	
	}
}
