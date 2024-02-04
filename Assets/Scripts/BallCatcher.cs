using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallCatcher : MonoBehaviour
{
    
public UnityEvent OnRestart;    

private void OnTriggerEnter (Collider collision) {

    if (collision.CompareTag("Ball")) {

        OnRestart?.Invoke();
    }
}



}
