using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speedRotation = 50f;
    private void Update()
    {
        transform.Rotate(0, 0, speedRotation * Time.deltaTime);
    }
}
