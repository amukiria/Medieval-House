using UnityEngine;

public class FanRotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 75f;
    [SerializeField] Vector3 rotateAngle = Vector3.up;
    void Update()
    {
       transform.Rotate(rotateSpeed * Time.deltaTime * rotateAngle);
    }
}
