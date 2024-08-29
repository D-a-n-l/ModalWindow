using UnityEngine;
using DG.Tweening;

public class RescaleObject : MonoBehaviour
{
    [SerializeField]
    private Transform _object;

    [SerializeField]
    private Vector3 _new;

    [SerializeField]
    private float _duration;

    private Vector3 _default = Vector3.one;

    public void Refresh()
    {
        _object.localScale = _new;

        _object.DOScale(_default, _duration);
    }
}