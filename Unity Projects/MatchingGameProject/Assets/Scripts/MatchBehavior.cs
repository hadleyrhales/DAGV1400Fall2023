using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent, matchEvent, noMatchEvent, noMatchDelayedEvent;

    public void Start()
    {
        startEvent.Invoke();
    }

    private IEnumerator OnTriggerEnter(Collider other) 
    {
        var tempObj = other.GetComponent<MatchBehavior>(); //gets match behavior script and sets it as a variable
        if (tempObj == null) //checks if variable is null
            yield break; //stops running rest of script
            
        var otherID = tempObj.idObj; //sets other objects idObj as otherID variable
        if (otherID == idObj) //checks if IDs are the same
        {
            matchEvent.Invoke(); //runs matchEvent if true
        }
        else 
        {
            noMatchEvent.Invoke(); //runs noMatchEvent if false
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke();
        }
    }
}
