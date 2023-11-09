using System;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, startEvent;

    public void Start()
    {
        startEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>(); //gets id container script and sets it as a variable
        if (tempObj == null) //checks if variable is null
            return; //stops running rest of script
            
        var otherID = tempObj.idObj; //sets other objects idObj as otherID variable
        if (otherID == idObj) //checks if IDs are the same
        {
            matchEvent.Invoke(); //runs matchEvent if true
        }
        else 
        {
            noMatchEvent.Invoke(); //runs noMatchEvent if false
        }
    }
}
