using Cysharp.Threading.Tasks;
using UnityEngine;

public class VrmAnimSample : MonoBehaviour
{
    [SerializeField] Animator _animator;

    async void Start()
    {
        _animator.SetInteger("animBaseInt", 3);
        
        // UniTaskでスペースキーを押したらアニメーションを変更する
        await UniTask.WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        _animator.Play("Layer_look_away", 1, 0.0f);
    }
}
