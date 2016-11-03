using UnityEngine;
using System.Collections;

public class TimeGame : MonoBehaviour {

    public float roundStartTime;
    public float playerWaitTime;
    int waitTime;
	void Start () {
        print("Press the space bar once you think the alloted time is up");
        SetNewRandomTime();
       
    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.Space)){
            playerWaitTime = Time.time - roundStartTime;
            Debug.Log("Tiempo del player: " + playerWaitTime);
            float error = Mathf.Abs(waitTime - playerWaitTime);
            print("You waited for" + playerWaitTime + " seconds. That's " + error + " seconds off.");
            SetNewRandomTime();
        }
	}
    void SetNewRandomTime()
	{
        waitTime = Random.Range(0,60);
        roundStartTime = Time.time;
        print(waitTime + " seconds.");
     
    }
}
