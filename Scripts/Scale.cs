using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        ChangeScale();
    }

    private void ChangeScale()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed);
    }
}
