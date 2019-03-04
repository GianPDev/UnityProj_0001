using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {

	// Use this for initialization
    public GameObject target;
    public Camera cam;
    private Vector3 pos;
    private Quaternion quaternion;
    private float aimAngle;
    private Vector3 lastPos;
	void Start () {
        if(target == null)
        {
            target = GameObject.Find("Target");
        }
        if(cam == null)
        {
            cam = Camera.main;
        }
        Debug.Log(target);
	}

    // Update is called once per frame
    void Update () {
        /*
        if(Input.GetMouseButtonDown(0))
        {
            pos = Input.mousePosition;
            pos.z = 1;
            Vector3 localPos = cam.ScreenToWorldPoint(pos);
            gameObject.transform.position = localPos;
            lastPos = localPos;
        }
        if(Input.GetMouseButton(0))
        {
            pos = Input.mousePosition;
            pos.z = 1;
            var localPos = cam.ScreenToWorldPoint(pos);
            target.transform.position = localPos;

            float dx = localPos.x - lastPos.x;
            float dy = localPos.y - lastPos.y;

            aimAngle = Mathf.Atan2(dy, dx);

            var ownLocal = new Vector3(gameObject.transform.position.x)

            Vector3 targetPos = new Vector3(
                    (gameObject.transform.position.x + target.transform.position.x) + (Mathf.Cos(aimAngle)), 
                    (gameObject.transform.position.y + target.transform.position.y) + (Mathf.Sin(aimAngle)), 1);

            target.transform.position = cam.ScreenToWorldPoint(targetPos);

            Debug.Log("Owner Pos: " + gameObject.transform.position);
            Debug.Log("Target Pos: " + target.transform.position);
            //Debug.Log("Mouse Position: " + localPos);
            //Debug.Log("Set Target Position to: " + target.transform.position);
        }
        */

        if (Input.GetMouseButtonDown(0))
        {
            pos = Input.mousePosition;
            pos.z = 1;
            gameObject.transform.position = cam.ScreenToWorldPoint(pos);
            lastPos = pos;
        }
        if (Input.GetMouseButton(0))
        {
            pos = cam.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 1;

            float dx = pos.x - gameObject.transform.position.x;
            float dy = pos.y - gameObject.transform.position.y;

            aimAngle = Mathf.Atan2(dy, dx);

            Debug.Log("aimAngle: " + aimAngle);


            Vector3 targetPos = new Vector3(
                    //(gameObject.transform.position.x) + (50 * Mathf.Cos(aimAngle)),
                    (50 * Mathf.Cos(aimAngle)),
                    //(gameObject.transform.position.y) + (50 * Mathf.Sin(aimAngle)), 1);
                    (50 * Mathf.Sin(aimAngle)), 1);
            Debug.Log("targetPos: " + targetPos);
            target.transform.position = cam.ScreenToWorldPoint(targetPos);
            

            Debug.Log("Owner Pos: " + gameObject.transform.position);
            Debug.Log("Target Pos: " + target.transform.position);
            //Debug.Log("Mouse Position: " + localPos);
            //Debug.Log("Set Target Position to: " + target.transform.position);
        }

        //Attempting to add a target which rotates around gameobject at a fixed distance using Vector3s and some maths
        //Due to Unity's world point, position, whatever, I have no idea what is going on. This formula works on Haxeflixel.
        //This kinda works, but it rotates to the bottom left of the screen instead of around the gameobject.
    }
}
