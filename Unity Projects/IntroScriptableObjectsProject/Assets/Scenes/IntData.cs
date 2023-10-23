using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]
public class IntData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
}
