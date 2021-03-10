using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimePickup : MonoBehaviour {
    
    private bool wasPickedUp = false;
    private bool pickedUp;
    public GameObject myTimeKeeper;
    
    // Start is called before the first frame update
    void Start()  {
        myTimeKeeper = GameObject.Find("TimeKeeper");
    }

    // Update is called once per frame
    void Update()  {
        var transform = this.GetComponent<Transform>();
        transform.localRotation *= Quaternion.Euler(0.0f, 0.0f, 200.0f * Time.deltaTime);
        if (wasPickedUp) {
            transform.localScale *= 0.8f;
        }
    }
    
    void OnTriggerEnter(Collider collider) {
        Debug.Log("on the trigger");
        if (collider.gameObject.CompareTag("Player") && !pickedUp) {
            pickedUp = true;
                myTimeKeeper.GetComponent<Timer>().timeRemaining += 15;
            Debug.Log("something collided with us");
            FindObjectOfType<AudioManager>().Play("yeah");
            // Debug.Log("Did it play?");
            Destroy(gameObject, 1.5f);
            wasPickedUp = true;
        }
    }
}
