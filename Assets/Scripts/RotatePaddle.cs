using UnityEngine;

public class RotatePaddle : MonoBehaviour
{
    float sensivity;

    private void Start()
    {
        sensivity = PlayerPrefs.GetFloat(SettingsScreen.SENSITIVITY_KEY);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 startPos = (Vector2)this.transform.position + touch.deltaPosition;
            this.transform.Rotate(0, 0, startPos.x * sensivity);
        }

    }
}
