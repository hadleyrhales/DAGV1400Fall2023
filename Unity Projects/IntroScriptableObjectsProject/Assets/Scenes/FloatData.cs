using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "Float Data")]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }
}
