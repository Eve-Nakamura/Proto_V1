using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public GameObject MinRange;
    public GameObject MaxRange;
    public GameObject StaticValue;
    public Vector2 curDist;
    public Vector2 prevDist;
    public float touchDelta;
    public float speedTouch0;
    public float minScrollSpeed;
    public float varianceInDistances = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved ) 
    {
            curDist = new Vector2(Input.GetTouch(0).position.x, 0f) - new Vector2(StaticValue.transform.position.x, StaticValue.transform.position.y); //current distance between finger and initial position (static value)
            prevDist = ((new Vector2(Input.GetTouch(0).position.x, 0f) - new Vector2(Input.GetTouch(0).deltaPosition.x, 0f)) - (new Vector2(StaticValue.transform.position.x, StaticValue.transform.position.y))); //difference in previous locations using delta positions
            touchDelta = curDist.magnitude - prevDist.magnitude;
            speedTouch0 = Input.GetTouch(0).deltaPosition.magnitude / Input.GetTouch(0).deltaTime;

            if ((touchDelta + varianceInDistances >= 1) && (speedTouch0 > minScrollSpeed))
            {
                if( gameObject.transform.position.x > MinRange.transform.position.x)
                {
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x - speedTouch0 * 0.001f, gameObject.transform.position.y, gameObject.transform.position.z);
                    /*selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView + (1 * speed), 15, 90);*/
                }

            }
            if ((touchDelta + varianceInDistances < 1) && (speedTouch0 > minScrollSpeed))
            {
                if (gameObject.transform.position.x < MaxRange.transform.position.x)
                {
                    gameObject.transform.position = new Vector3(gameObject.transform.position.x + speedTouch0 * 0.001f, gameObject.transform.position.y, gameObject.transform.position.z);
                    /*selectedCamera.fieldOfView = Mathf.Clamp(selectedCamera.fieldOfView + (1 * speed), 15, 90);*/
                }
            }
        }

    }
}
