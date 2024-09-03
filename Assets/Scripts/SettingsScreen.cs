using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : MonoBehaviour
{
    [SerializeField]private Slider slider;
    public static string SENSITIVITY_KEY = "sensitivity";

    public void BackButton()
    {
        this.gameObject.SetActive(false);
    }

    public void SettingsButton()
    {
        this.gameObject.SetActive(true);
    }
    
    public void OnValueChanged()
    {
        PlayerPrefs.SetFloat(SettingsScreen.SENSITIVITY_KEY, slider.value);
        //Debug.Log("playerpref senstivity set to " + slider.value);
    }

}
