using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent; 
    
    private void Start()
    {
        startEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
