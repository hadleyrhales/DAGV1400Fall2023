using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class AmmoTextLabelBehavior : MonoBehaviour
{
    public Text label;
    public IntData dataObj;
    
    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
