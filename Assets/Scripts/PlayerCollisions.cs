using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{        
    // bool doorIsOpen = false;
    // float doorTimer = 0.0f;
    // public float doorOpenTime = 3.0f;
    // public AudioClip doorOpenSound;
    // public AudioClip doorShutSound;
    GameObject currentDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast (transform.position, transform.forward, out hit, 3)) {
            if (hit.collider.gameObject.tag == "playerDoor") {
                currentDoor = hit.collider.gameObject;
                currentDoor.SendMessage("DoorCheck");
            }
        }

        // if (doorIsOpen) {
        //     doorTimer += Time.deltaTime;

        //     if (doorTimer > doorOpenTime) {
        //         Door(doorShutSound, false, "doorShut", currentDoor);
        //         doorTimer = 0.0f;
        //     }
        // }
    }

    // void OnControllerColliderHit(ControllerColliderHit hit) {
    //     currentDoor = hit.gameObject;
    //     if (hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
    //         Door(doorOpenSound, true, "doorOpen", currentDoor);
    //     }
    // }

    // void Door(AudioClip aClip, bool openCheck, string animName, GameObject thisDoor) {
    //     doorIsOpen = openCheck;
    //     thisDoor.GetComponent<AudioSource>().PlayOneShot(aClip);
    //     thisDoor.transform.parent.GetComponent<Animation>().Play(animName);
    // }
}
