using UnityEngine;

public class PanCamera : MonoBehaviour
{
    private void Update()
    {
        transform.position = Vector3.zero.WithX(Mathf.Sin(Time.time * 0.5f)) * 0.5f;
    }
}