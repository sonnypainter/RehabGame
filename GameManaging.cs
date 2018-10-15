using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManaging : MonoBehaviour {

    public GameObject leftController;
    public GameObject rightController;
    public GameObject leftBox;
    public GameObject rightBox;
    public Slider leftSlider;
    public Slider rightSlider;

    public Text leftStartingPos;
    public Text leftCurrentDist;
    public Text rightStartingPos;
    public Text rightCurrentDist;

    public Text leftControllerPosX;
    public Text leftControllerPosY;
    public Text leftControllerPosZ;
    public Text rightControllerPosX;
    public Text rightControllerPosY;
    public Text rightControllerPosZ;

    private float leftDist;
    private float rightDist;


    // Use this for initialization
    void Start () {

        leftSlider.minValue = 10;
        leftSlider.maxValue = 100;
        leftSlider.wholeNumbers = true;
        leftSlider.value = 10;

        rightSlider.minValue = 10;
        rightSlider.maxValue = 100;
        rightSlider.wholeNumbers = true;
        rightSlider.value = 10;
		
	}
	
	// Update is called once per frame
	void Update () {

        //update boxes based on slider value

        leftStartingPos.text = leftSlider.value.ToString();
        rightStartingPos.text = rightSlider.value.ToString();

        leftDist = Vector3.Distance(leftController.transform.position, leftBox.transform.position);
        rightDist = Vector3.Distance(rightController.transform.position, rightBox.transform.position);

        leftCurrentDist.text = leftDist.ToString();
        rightCurrentDist.text = rightDist.ToString();

        leftControllerPosX.text = leftController.transform.position.x.ToString();
        leftControllerPosY.text = leftController.transform.position.y.ToString();
        leftControllerPosZ.text = leftController.transform.position.z.ToString();
        rightControllerPosX.text = rightController.transform.position.x.ToString();
        rightControllerPosY.text = rightController.transform.position.y.ToString();
        rightControllerPosZ.text = rightController.transform.position.z.ToString();

    }
}
