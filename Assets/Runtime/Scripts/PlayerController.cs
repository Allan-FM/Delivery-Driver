using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speedRotation = 50f;
    private void Update()
    {
        transform.Rotate(0, 0, speedRotation * Time.deltaTime);
        transform.Translate(0, 0.01f, 0);
    }
}
