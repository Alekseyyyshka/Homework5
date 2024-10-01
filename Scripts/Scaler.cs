using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Change();
    }

    private void Change()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed);
    }
}
