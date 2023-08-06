using UniRx;
using UnityEngine;

public class VrmAnimSample : MonoBehaviour
{
    [SerializeField] Animator _animator;

    void Start()
    {
        _animator.SetInteger("animBaseInt", 3);
        
        // UniRXでスペースキーを押したらアニメーションを変更する
        Observable.EveryUpdate()
            .Where(_ => Input.GetKeyDown(KeyCode.Space))
            .Subscribe(_ =>
            {
                _animator.Play("Layer_look_away", 1, 0.0f);
            });
    }
}
