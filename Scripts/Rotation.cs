using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Rotate();

       
    }

    private void Rotate()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
