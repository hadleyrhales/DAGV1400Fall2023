using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehavior : MonoBehaviour
{
    public UnityEvent awakeEvent, visibleEvent, disableEvent; 
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void OnBecameVisible()
    {
        visibleEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
