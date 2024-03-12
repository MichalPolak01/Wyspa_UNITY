using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WolfBite : MonoBehaviour
{
    GameObject _player;
    public Text textHints;
    bool isMovementBlocked = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player && !isMovementBlocked)
        {
            isMovementBlocked = true;
            textHints.SendMessage("ShowHint", "Zostałeś zaatakowany przez wilka!\n Umierasz...");
            Debug.Log("Wolf ate the player!");
            StartCoroutine(DelayedLoadScene("Menu", 3f));
        }
    }

    IEnumerator DelayedLoadScene(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);

        SceneManager.LoadScene(sceneName);
    }
}
