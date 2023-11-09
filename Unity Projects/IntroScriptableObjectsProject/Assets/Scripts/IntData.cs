using UnityEngine;

[CreateAssetMenu(fileName = "New Int Data", menuName = "Int Data")]
public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
