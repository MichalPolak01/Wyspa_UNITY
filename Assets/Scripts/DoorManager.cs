using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    bool doorIsOpen = false;
    float doorTimer = 0.0f;
    public float doorOpenTime = 3.0f;
    public AudioClip doorOpenSound;
    public AudioClip doorShutSound;
    // GameObject currentDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpen) {
            doorTimer += Time.deltaTime;

            if (doorTimer > doorOpenTime) {
                Door(doorShutSound, false, "doorShut");
                doorTimer = 0.0f;
            }
        }
    }

    void DoorCheck() {
        if (!doorIsOpen) {
            Door(doorOpenSound, true, "doorOpen");
        }
    }

    // void OnControllerColliderHit(ControllerColliderHit hit) {
    //     currentDoor = hit.gameObject;
    //     if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
    //         Door(doorOpenSound, true, "doorOpen", currentDoor);
    //     }
    // }

    void Door(AudioClip aClip, bool openCheck, string animName) {
        doorIsOpen = openCheck;
        this.GetComponent<AudioSource>().PlayOneShot(aClip);
        this.transform.parent.GetComponent<Animation>().Play(animName);
    }
}
