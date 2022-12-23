using TMPro;
using DG.Tweening;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    [SerializeField] GameObject loginCanvas;
    [SerializeField] GameObject rejectionCanvas;

    [SerializeField] Camera cityCamera;
    [SerializeField] Transform villageTarget;    
    [SerializeField] Transform cityTarget;
    
    [SerializeField] TMP_InputField usernameInput;
    [SerializeField] TMP_InputField passwordInput;
    [SerializeField] TMP_InputField netWorthInput;
    [SerializeField] TMP_Text displayText;
    [SerializeField] float timeDelay = 2f;

    const float  upperWorthBounds = 4500000f;
    const float lowerWorthBounds = 1000000f;
    Vector3 cameraRotateAngle = new Vector3(0, 90, 0);
    Vector3 camera2RotateAngle = new Vector3(0, 165, 0);

    private void Start()
    {
        loginCanvas.SetActive(true);
        rejectionCanvas.SetActive(false);
    }

    public void LoginInAgain()
    {
        if (usernameInput.text == "Username" && passwordInput.text == "Password")
        {
            if (float.Parse(netWorthInput.text) >= lowerWorthBounds && float.Parse(netWorthInput.text) <= upperWorthBounds)
            {
                Debug.Log("// go to Village house");
                loginCanvas.SetActive(false);
                rejectionCanvas.SetActive(false);
                //TODO: DoTween DoMove(Village)
                cityCamera.transform.DOMove(villageTarget.position, timeDelay);
                cityCamera.transform.DORotate(cameraRotateAngle, timeDelay);
            }
            else if(float.Parse(netWorthInput.text) >= upperWorthBounds)
            {
                Debug.Log("// go to City house");
                loginCanvas.SetActive(false);
                rejectionCanvas.SetActive(false);
                //TODO: DoTween DoMove(City)
                cityCamera.transform.DOMove(cityTarget.position, timeDelay);
                cityCamera.transform.DORotate(camera2RotateAngle, timeDelay);
            }
            else
            {
                loginCanvas.SetActive(false);
                rejectionCanvas.SetActive(true);
                displayText.text = "Sorry! Come back next time when you're eligible";
            }
        }
        else
        {
            loginCanvas.SetActive(false);
            rejectionCanvas.SetActive(true);
            displayText.text = "Invalid Login Credentials";
        }

    }
    public void RetryLogin()
    {
        loginCanvas.SetActive(true);
        rejectionCanvas.SetActive(false);
    }
}
